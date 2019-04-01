using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Clicker : MonoBehaviour
{
    [Header("Multiplicateurs")]
    public static Scr_Clicker Scr_ClickerStatic;
    public float multiplicateur_click;
    public float click_value;
    public float multiplicateur_base;
    public float alchimistes;
    public float multiplicateur_alchimistes;
    [Header("FPS")]
    
    public float fps;
    [Header("Xp par secondes")]
    public Text xp_text;
    public Text xpPerSeconds;
    public Text fpsText;
    private float precision = 100;
    [Header("Taux de farm des salles")]
    public float xp;
    [Header("Barres de progression des salles")]
    public Image progressBar;
    [Header("Roues de progression des pouvoirs")]
    public Image progressWheelA;
    public Image progressWheelB;
    public Image progressWheelC;
    public Image progressWheelD;
    public float cooldownPowerA;
    public float cooldownPowerB;
    public float cooldownPowerC;
    public float cooldownPowerD;
    private float powerA;
    private float powerB;
    private float powerC;
    private float powerD;
    private bool powerA_active = false;
    private bool powerB_active = false;
    private bool powerC_active = false;
    private bool powerD_active = false;
    public Toggle powA_btn;
    public Toggle powB_btn;
    public Toggle powC_btn;
    public Toggle powD_btn;
    public float fréquenceVisuelleDuRechargement;
    public Color SelectDuBouttonPouvoir;
    [Header("Particules")]
    public ParticleSystem plusXeffect;
    public ParticleSystem manaBurst;
    public GameObject powerActive_A;
    public GameObject powerActive_B;
    public GameObject powerActive_C;
    public GameObject powerActive_D;
    public Text plusXtext;
    public float deltaTime;
    public System.Timers.Timer timeur;

    private void Awake()
    {
        Scr_ClickerStatic = this;
        xpPerSeconds.text = (multiplicateur_base / 10).ToString("0" + ".##" + " xp/s");
    }


    void Start()
    {
        StartCoroutine("CooldownPA");
        StartCoroutine("CooldownPB");
        StartCoroutine("CooldownPC");
        StartCoroutine("CooldownPD");
        powerA = 0;
        powerB = 0;
        powerC = 0;
        powerD = 0;
        timeur = new System.Timers.Timer(10);
        timeur.AutoReset = true;
        timeur.Enabled = true;
        timeur.Elapsed += new ElapsedEventHandler(OnTimedEvent);
    }

    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Debug.Log("timeur");

        xp += multiplicateur_base * multiplicateur_alchimistes *  0.01f; //le total général d'1 xp par seconde est incrémenté.
        Scr_XP.Scr_XPStatic.xp += multiplicateur_base * multiplicateur_alchimistes * 0.01f;
        if (xp >= 1f)
        {
            xp = 0;
        }
    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil(fps).ToString();

        progressBar.fillAmount = xp;
        xp_text.text = Scr_XP.Scr_XPStatic.xp.ToString(".#" + "0"); //le texte général est modifié
        xpPerSeconds.text = (multiplicateur_base * multiplicateur_alchimistes).ToString("0" + ".##" + " xp/s");

        multiplicateur_alchimistes = 1 + (alchimistes / 10);

    }
    
    public void ClickXP()
    {
      
            plusXtext.text = (multiplicateur_click * click_value).ToString("+0" + ".#" + "0");
            Scr_XP.Scr_XPStatic.xp += (click_value * multiplicateur_click);
            ParticleSystem clone = (ParticleSystem)Instantiate(plusXeffect, plusXeffect.transform.position, plusXeffect.transform.rotation);
            ParticleSystem clone2 = (ParticleSystem)Instantiate(manaBurst, manaBurst.transform.position, manaBurst.transform.rotation);
            Destroy(clone.gameObject, 1);
            xp += multiplicateur_click * click_value;
            Scr_XP.Scr_XPStatic.xp = Mathf.Floor(Scr_XP.Scr_XPStatic.xp * precision + 0.5f) / precision;
            Debug.Log(Scr_XP.Scr_XPStatic.xp);
        
    }

    public void BoostXpGoldenStudent()
    {
        StartCoroutine("BoostXpGoldStudent");
    }

    IEnumerator BoostXpGoldStudent()
    {
        multiplicateur_base = multiplicateur_base * 5;
        multiplicateur_click = multiplicateur_click * 5;
        yield return new WaitForSecondsRealtime(10f);
        multiplicateur_base = multiplicateur_base / 5;
        multiplicateur_click = multiplicateur_click / 5;
    }


    public void RoomA()
    {
        Debug.Log("Click RoomA");
    }
    public void RoomB()
    {
        Debug.Log("Click RoomB");
    }
    public void RoomC()
    {
        Debug.Log("Click RoomC");
    }
    public void RoomD()
    {
        Debug.Log("Click RoomD");
    }


    public void PowerA()
    {
        if (powerA_active == true)
        {
            if (powerActive_A.activeSelf == true)
            {
                powerActive_A.SetActive(false);
            }
        }

    }

    IEnumerator CooldownPA()
    {

        if (powerA < cooldownPowerA)
        {

            powerA = powerA + fréquenceVisuelleDuRechargement;
            progressWheelA.fillAmount = 1 - powerA / cooldownPowerA;
            yield return new WaitForSecondsRealtime(fréquenceVisuelleDuRechargement);
            StartCoroutine("CooldownPA");
            if (powA_btn.interactable == true)
            {
                powA_btn.interactable = false;
            }
        }
        else
        {
            if (powA_btn.interactable == false)
            {
                yield return new WaitForSecondsRealtime(fréquenceVisuelleDuRechargement + 0.01f);
                powA_btn.interactable = true;
                powerA_active = true;
                if (powerActive_A.activeSelf == false)
                {
                    powerActive_A.SetActive(true);
                }
            }


        }

    }
    IEnumerator CooldownPB()
    {

        if (powerB < cooldownPowerB)
        {

            powerB = powerB + fréquenceVisuelleDuRechargement;
            progressWheelB.fillAmount = 1 - powerB / cooldownPowerB;
            yield return new WaitForSecondsRealtime(fréquenceVisuelleDuRechargement);
            StartCoroutine("CooldownPB");
            if (powB_btn.interactable == true)
            {
                powB_btn.interactable = false;
            }
        }
        else
        {
            if (powB_btn.interactable == false)
            {
                yield return new WaitForSecondsRealtime(fréquenceVisuelleDuRechargement + 0.01f);
                powB_btn.interactable = true;
                powerB_active = true;
                if (powerActive_B.activeSelf == false)
                {
                    powerActive_B.SetActive(true);
                }
            }


        }

    }
    IEnumerator CooldownPC()
    {

        if (powerC < cooldownPowerC)
        {

            powerC = powerC + fréquenceVisuelleDuRechargement;
            progressWheelC.fillAmount = 1 - powerC / cooldownPowerC;
            yield return new WaitForSecondsRealtime(fréquenceVisuelleDuRechargement);
            StartCoroutine("CooldownPC");
            if (powC_btn.interactable == true)
            {
                powC_btn.interactable = false;
            }
        }
        else
        {
            if (powC_btn.interactable == false)
            {
                yield return new WaitForSecondsRealtime(fréquenceVisuelleDuRechargement + 0.01f);
                powC_btn.interactable = true;
                powerC_active = true;
                if (powerActive_C.activeSelf == false)
                {
                    powerActive_C.SetActive(true);
                }
            }


        }

    }
    IEnumerator CooldownPD()
    {

        if (powerD < cooldownPowerD)
        {

            powerD = powerD + fréquenceVisuelleDuRechargement;
            progressWheelD.fillAmount = 1 - powerD / cooldownPowerD;
            yield return new WaitForSecondsRealtime(fréquenceVisuelleDuRechargement);
            StartCoroutine("CooldownPD");
            if (powD_btn.interactable == true)
            {
                powD_btn.interactable = false;
            }
        }
        else
        {
            if (powD_btn.interactable == false)
            {
                yield return new WaitForSecondsRealtime(fréquenceVisuelleDuRechargement + 0.01f);
                powD_btn.interactable = true;
                powerD_active = true;
                if (powerActive_D.activeSelf == false)
                {
                    powerActive_D.SetActive(true);
                }
            }


        }

    }

}
    

using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Clicker : MonoBehaviour
{
    [Header ("Multiplicateurs")]
    public static Scr_Clicker Scr_ClickerStatic;
    public float multiplicateur_click = 1;
    public float multiplicateur_base = 1;
    [Header("Multiplicateurs des salles")]
    public float multiplicateurA = 1;
    public float multiplicateurB = 1;
    public float multiplicateurC = 1;
    public float multiplicateurD = 1;
    [Header("FPS")]
    private float fps2;
    public float fps;
    [Header("Xp par secondes")]
    public Text xp_text;
    private float xpPerSecondsTotal;
    public Text xpPerSeconds_text;
    public Text fpsText;
    private float precision = 100;
    public Text xpPerSecondsRA;
    public Text xpPerSecondsRB;
    public Text xpPerSecondsRC;
    public Text xpPerSecondsRD;
    [Header("Taux de farm des salles")]
    public float xpRA;
    public float xpRB;
    public float xpRC;
    public float xpRD;
    [Header("Barres de progression des salles")]
    public Image progressBarRA;
    public Image progressBarRB;
    public Image progressBarRC;
    public Image progressBarRD;
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
        progressBarRA.fillAmount = xpRA * 10;
        xpPerSecondsRA.text = (multiplicateur_base * multiplicateurA / 10).ToString("0" + ".##" + " xp/s");
        xpPerSecondsRB.text = (multiplicateur_base * multiplicateurB / 10).ToString("0" + ".##" + " xp/s");
        xpPerSecondsRC.text = (multiplicateur_base * multiplicateurC / 10).ToString("0" + ".##" + " xp/s");
        xpPerSecondsRD.text = (multiplicateur_base * multiplicateurD / 10).ToString("0" + ".##" + " xp/s");
        xpPerSecondsTotal = (multiplicateur_base * multiplicateurA / 10) + (multiplicateur_base * multiplicateurB / 10) + (multiplicateur_base * multiplicateurC / 10) + (multiplicateur_base * multiplicateurD / 10);
        xpPerSeconds_text.text = xpPerSecondsTotal.ToString("0" + ".##" + " Global XP/s");

    }


    void Start()
    {
        StartCoroutine("FarmingRA");
        StartCoroutine("FarmingRB");
        StartCoroutine("FarmingRC");
        StartCoroutine("FarmingRD");
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
        xpRB = (5 / 3000f * multiplicateur_base * multiplicateurB) + xpRB;

    }

    void Update()
    {



        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil(fps).ToString();


        



    }
    
    public void PowerA()
    {
        if (powerA_active == true)
        {
            if (powerActive_A.activeSelf == true)
            {
                powerActive_A.SetActive(false);
            }
            //ColorBlock cb = powA_btn.colors;
            //cb.pressedColor = SelectDuBouttonPouvoir;
            //powA_btn.colors.normalColor = cb;
            Debug.Log("POWEEERRRRA");
        }
        
    }

    IEnumerator CooldownPA()
    {
        
        if (powerA < cooldownPowerA)
        {
            
            powerA = powerA + fréquenceVisuelleDuRechargement;
            progressWheelA.fillAmount = 1- powerA / cooldownPowerA;
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

    IEnumerator FarmingRA()
    {
        if (xpRA >= 0.1f)
        {
            xpRA = 0;
            
        }
        yield return new WaitForSeconds(0.01f); //se fait toutes les 0.01 secondes
        progressBarRA.fillAmount = xpRA * 10 / 1;
        xpRA = (5 / 3000f * multiplicateur_base * multiplicateurA) + xpRA; //le total général d'1 xp par seconde est incrémenté.
        Scr_XP.Scr_XPStatic.xp = (5 / 3000f * multiplicateur_base * multiplicateurA) + Scr_XP.Scr_XPStatic.xp;
        xp_text.text = Scr_XP.Scr_XPStatic.xp.ToString(".#" + "0"); //le texte général est modifié

        StartCoroutine("FarmingRA"); //recommence 
    }

    IEnumerator FarmingRB()
    {
        if (xpRB >= 0.1f) //Restart de la barre quand elle est remplie à 100%
        {
            xpRB = 0;
            
        }
        yield return new WaitForSeconds(0.01f); //se fait toutes les 0.01 secondes
        progressBarRB.fillAmount = xpRB * 10 / 1;
        xpRB = (5 / 3000f * multiplicateur_base * multiplicateurB) + xpRB; //le total général d'1 xp par seconde est incrémenté.
        Scr_XP.Scr_XPStatic.xp = (5 / 3000f * multiplicateur_base * multiplicateurB) + Scr_XP.Scr_XPStatic.xp;
        xp_text.text = Scr_XP.Scr_XPStatic.xp.ToString(".#" + "0"); //le texte général est modifié
        StartCoroutine("FarmingRB"); //recommence 
    }
    IEnumerator FarmingRC()
    {
        if (xpRC >= 0.1f)
        {
            xpRC = 0;
            
        }
        yield return new WaitForSeconds(0.01f); //se fait toutes les 0.01 secondes
        progressBarRC.fillAmount = xpRC * 10 / 1;
        xpRC = (5 / 3000f * multiplicateur_base * multiplicateurC) + xpRC; //le total général d'1 xp par seconde est incrémenté.
        Scr_XP.Scr_XPStatic.xp = (5 / 3000f * multiplicateur_base * multiplicateurC) + Scr_XP.Scr_XPStatic.xp;
        xp_text.text = Scr_XP.Scr_XPStatic.xp.ToString(".#" + "0"); //le texte général est modifié
        StartCoroutine("FarmingRC"); //recommence 
    }
    IEnumerator FarmingRD()
    {
        if (xpRD >= 0.1f)
        {
            xpRD = 0;
            
        }
        yield return new WaitForSeconds(0.01f); //se fait toutes les 0.01 secondes
        progressBarRD.fillAmount = xpRD * 10 / 1;
        xpRD = (5 / 3000f * multiplicateur_base * multiplicateurD) + xpRD; //le total général d'1 xp par seconde est incrémenté.
        Scr_XP.Scr_XPStatic.xp = (5 / 3000f * multiplicateur_base * multiplicateurD) + Scr_XP.Scr_XPStatic.xp;
        xp_text.text = Scr_XP.Scr_XPStatic.xp.ToString(".#" + "0"); //le texte général est modifié
        StartCoroutine("FarmingRD"); //recommence 
    }
    public void OnMouseDown()
    {
        xpPerSecondsRA.text = (multiplicateur_base * multiplicateurA / 10).ToString("0" + ".##" + " xp/s");
        xpPerSecondsRB.text = (multiplicateur_base * multiplicateurB / 10).ToString("0" + ".##" + " xp/s");
        xpPerSecondsRC.text = (multiplicateur_base * multiplicateurC / 10).ToString("0" + ".##" + " xp/s");
        xpPerSecondsRD.text = (multiplicateur_base * multiplicateurD / 10).ToString("0" + ".##" + " xp/s");
        xpPerSecondsTotal = (multiplicateur_base * multiplicateurA / 10) + (multiplicateur_base * multiplicateurB / 10) + (multiplicateur_base * multiplicateurC / 10) + (multiplicateur_base * multiplicateurD / 10);
        xpPerSeconds_text.text = xpPerSecondsTotal.ToString("0" + ".##" + " Global XP/s");
    }
    public void ClickXP()
    {
        Debug.Log("clic xp");
        plusXtext.text = (multiplicateur_click / 10).ToString("+0" + ".#" + "0");
        Scr_XP.Scr_XPStatic.xp = (0.10f * multiplicateur_click) + Scr_XP.Scr_XPStatic.xp;
        ParticleSystem clone = (ParticleSystem)Instantiate(plusXeffect, plusXeffect.transform.position, plusXeffect.transform.rotation);
        Destroy(clone.gameObject, 1);


        Scr_XP.Scr_XPStatic.xp = Mathf.Floor(Scr_XP.Scr_XPStatic.xp * precision + 0.5f) / precision;
        //xp_text.text = Scr_XP.Scr_XPStatic.xp.ToString(".##");
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
    
}

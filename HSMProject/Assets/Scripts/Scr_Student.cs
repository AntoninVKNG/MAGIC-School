using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Student : MonoBehaviour
{
    public static Scr_Student Scr_StudentStatic;

    [Header("Boutons classiques")]
    public Button A_btn;
    public Button B_btn;
    public Button C_btn;
    public Button D_btn;

    [Header("Boutons de confirmation")]
    public GameObject A_btn_confirm;
    public GameObject B_btn_confirm;
    public GameObject C_btn_confirm;
    public GameObject D_btn_confirm;

    [Header("Elèves instanciés")]
    public GameObject fireStudent;
    public GameObject fireStudent2;
    public GameObject fireStudent3;
    public GameObject fireStudent4;

    public GameObject poisonStudent;
    public GameObject poisonStudent2;
    public GameObject poisonStudent3;
    public GameObject poisonStudent4;


    public GameObject explosionStudent;
    public GameObject explosionStudent2;
    public GameObject explosionStudent3;
    public GameObject explosionStudent4;


    public GameObject invocationStudent;
    public GameObject invocationStudent2;
    public GameObject invocationStudent3;
    public GameObject invocationStudent4;

    [Header("Canvas")]
    public GameObject Canvas;

    public GameObject canvasFire1;
    public GameObject canvasFire2;
    public GameObject canvasFire3;
    public GameObject canvasFire4;

    public GameObject canvasAlchimie1;
    public GameObject canvasAlchimie2;
    public GameObject canvasAlchimie3;
    public GameObject canvasAlchimie4;

    public GameObject canvasMagieNoir1;
    public GameObject canvasMagieNoir2;
    public GameObject canvasMagieNoir3;
    public GameObject canvasMagieNoir4;

    public GameObject canvasInvocation1;
    public GameObject canvasInvocation2;
    public GameObject canvasInvocation3;
    public GameObject canvasInvocation4;

    public static Vector3 pos;
    public Vector3 pos1;

    [Header("Prix des Achats")]
    public float prixMagieALv0;
    public float prixMagieBLv0;
    public float prixMagieCLv0;
    public float prixMagieDLv0;

    public float alchimistes;
    public float pyromanciens;
    public float mageNoirs;
    public float invocateurs;

    [Header("Affichage dans le boutton")]
    public Text TexteMagieA;
    public Text TexteMagieB;
    public Text TexteMagieC;
    public Text TexteMagieD;

    [Header("Emplacements")]
    public List<GameObject> Emplacements = new List<GameObject>();





    private void Awake()
    {
        TexteMagieA.text = prixMagieALv0.ToString();
        TexteMagieB.text = prixMagieBLv0.ToString();
        TexteMagieC.text = prixMagieCLv0.ToString();
        TexteMagieD.text = prixMagieDLv0.ToString();



        pos = this.transform.position;

        Scr_StudentStatic = this;
    }

    void Start()
    {


    }


    
    public void DetectionLevel(Collision other)
    {
        if (other.gameObject.tag == "0")
        {
            Debug.Log("<b>Niveau0</b>");
            SwitchCanvasApparition();
        }

        // FireUpgrade 

        else if (other.gameObject.tag == "1") //FireUp1
        {
            Debug.Log("Niveau+1");
            if (canvasFire1.activeSelf == false)
            {
                Debug.Log("Canvas2");
                canvasFire2.SetActive(true);
                TexteMagieA.text = (prixMagieALv0 * (pyromanciens / 10 + 1)).ToString();

            }
        }
        if (other.gameObject.tag == "2") //FireUp2
        {
            if (canvasFire2.activeSelf == false)
            {
                canvasFire3.SetActive(true);
                TexteMagieA.text = (prixMagieALv0 * (pyromanciens / 10 + 1)).ToString();

            }
        }
        if (other.gameObject.tag == "3") //FireUp3
        {
            if (canvasFire3.activeSelf == false)
            {
                canvasFire3.SetActive(true);
                TexteMagieA.text = (prixMagieALv0 * (pyromanciens / 10 + 1)).ToString();

            }
        }

        if (other.gameObject.tag == "4") //FireUp4
        {
            if (canvasFire4.activeSelf == false)
            {
                canvasFire4.SetActive(true);
                TexteMagieA.text = (prixMagieALv0 * (pyromanciens / 10 + 1)).ToString();

            }
        }

        // AlchimieUpgrade 

        if (other.gameObject.tag == "5") //AlchimieUp1
        {
            if (canvasAlchimie1.activeSelf == false)
            {
                canvasAlchimie1.SetActive(true);
                TexteMagieA.text = (prixMagieBLv0 * (alchimistes / 10 + 1)).ToString();
            }
        }
        if (other.gameObject.tag == "6") //AlchimieUp2
        {
            if (canvasAlchimie2.activeSelf == false)
            {
                canvasAlchimie2.SetActive(true);
                TexteMagieA.text = (prixMagieBLv0 * (alchimistes / 10 + 1)).ToString();
            }
        }
        if (other.gameObject.tag == "7") //AlchimieUp3
        {
            if (canvasAlchimie3.activeSelf == false)
            {
                canvasAlchimie3.SetActive(true);
                TexteMagieA.text = (prixMagieBLv0 * (alchimistes / 10 + 1)).ToString();
            }
        }

        if (other.gameObject.tag == "8") //AlchimieUp4
        {
            if (canvasAlchimie4.activeSelf == false)
            {
                canvasAlchimie4.SetActive(true);
                TexteMagieA.text = (prixMagieBLv0 * (alchimistes / 10 + 1)).ToString();
            }
        }

        // MagieNoirUpgrade 

        if (other.gameObject.tag == "9") //MagieNoirUp1
        {
            if (canvasMagieNoir1.activeSelf == false)
            {
                canvasMagieNoir1.SetActive(true);
                TexteMagieA.text = (prixMagieCLv0 * (mageNoirs / 10 + 1)).ToString();
            }
        }
        if (other.gameObject.tag == "10") //MagieNoirUp2
        {
            if (canvasMagieNoir2.activeSelf == false)
            {
                canvasMagieNoir2.SetActive(true);
                TexteMagieA.text = (prixMagieCLv0 * (mageNoirs / 10 + 1)).ToString();
            }
        }
        if (other.gameObject.tag == "11") //MagieNoirUp3
        {
            if (canvasMagieNoir3.activeSelf == false)
            {
                canvasMagieNoir3.SetActive(true);
                TexteMagieA.text = (prixMagieCLv0 * (mageNoirs / 10 + 1)).ToString();
            }
        }
        if (other.gameObject.tag == "12") //MagieNoirUp4
        {
            if (canvasMagieNoir4.activeSelf == false)
            {
                canvasMagieNoir4.SetActive(true);
                TexteMagieA.text = (prixMagieCLv0 * (mageNoirs / 10 + 1)).ToString();
            }
        }

        //InvocationUpgrade

        if (other.gameObject.tag == "13") //InvocationUp1
        {
            if (canvasInvocation1.activeSelf == false)
            {
                canvasInvocation1.SetActive(true);
                TexteMagieA.text = (prixMagieDLv0 * (invocateurs / 10 + 1)).ToString();
            }
        }
        if (other.gameObject.tag == "14") //InvocationUp2
        {
            if (canvasInvocation2.activeSelf == false)
            {
                canvasInvocation2.SetActive(true);
                TexteMagieA.text = (prixMagieDLv0 * (invocateurs / 10 + 1)).ToString();
            }
        }
        if (other.gameObject.tag == "15") //InvocationUp3
        {
            if (canvasInvocation3.activeSelf == false)
            {
                canvasInvocation3.SetActive(true);
                TexteMagieA.text = (prixMagieDLv0 * (invocateurs / 10 + 1)).ToString();
            }
        }

        if (other.gameObject.tag == "16") //InvocationUp4
        {
            if (canvasInvocation4.activeSelf == false)
            {
                canvasInvocation4.SetActive(true);
                TexteMagieA.text = (prixMagieDLv0 * (invocateurs / 10 + 1)).ToString();
            }
        }



    }


    private void Update()
    {
        if (Canvas.activeSelf == true)
        {
            //Bouton A
            if (Scr_XP.Scr_XPStatic.xp >= prixMagieALv0 && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
            {
                A_btn.interactable = true; // le bouton deviens actif
            }
            else if (Scr_XP.Scr_XPStatic.xp < prixMagieALv0 && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
            {
                A_btn.interactable = false; // le bouton se désactive
            }
            //Bouton B
            if (Scr_XP.Scr_XPStatic.xp >= prixMagieBLv0 && B_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
            {
                B_btn.interactable = true; // le bouton deviens actif
            }
            else if (Scr_XP.Scr_XPStatic.xp < prixMagieBLv0 && B_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
            {
                B_btn.interactable = false; // le bouton se désactive
            }
            //Bouton C
            if (Scr_XP.Scr_XPStatic.xp >= prixMagieCLv0 && C_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
            {
                C_btn.interactable = true; // le bouton deviens actif
            }
            else if (Scr_XP.Scr_XPStatic.xp < prixMagieCLv0 && C_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
            {
                C_btn.interactable = false; // le bouton se désactive
            }
            //Bouton D
            if (Scr_XP.Scr_XPStatic.xp >= prixMagieDLv0 && D_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
            {
                D_btn.interactable = true; // le bouton deviens actif
            }
            else if (Scr_XP.Scr_XPStatic.xp < prixMagieDLv0 && D_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
            {
                D_btn.interactable = false; // le bouton se désactive
            }

            //Canvas Fire
            if (canvasFire1.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    A_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    A_btn.interactable = false; // le bouton se désactive
                }
            }

            if (canvasFire2.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    A_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    A_btn.interactable = false; // le bouton se désactive
                }
            }

            if (canvasFire3.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    A_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    A_btn.interactable = false; // le bouton se désactive
                }
            }

            if (canvasFire4.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    A_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    A_btn.interactable = false; // le bouton se désactive
                }
            }

            if (canvasFire4.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    A_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieALv0 * (pyromanciens / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    A_btn.interactable = false; // le bouton se désactive
                }
            }

            //Canvas Alchimie
            if (canvasAlchimie1.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieBLv0 * (alchimistes / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    B_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieBLv0 * (alchimistes / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    B_btn.interactable = false; // le bouton se désactive
                }
            }
            if (canvasAlchimie2.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieBLv0 * (alchimistes / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    B_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieBLv0 * (alchimistes / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    B_btn.interactable = false; // le bouton se désactive
                }
            }
            if (canvasAlchimie3.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieBLv0 * (alchimistes / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    B_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieBLv0 * (alchimistes / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    B_btn.interactable = false; // le bouton se désactive
                }
            }
            if (canvasAlchimie4.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieBLv0 * (alchimistes / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    B_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieBLv0 * (alchimistes / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    B_btn.interactable = false; // le bouton se désactive
                }
            }

            //Canvas Magie Noir

            if (canvasMagieNoir1.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieCLv0 * (mageNoirs / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    C_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieCLv0 * (mageNoirs / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    C_btn.interactable = false; // le bouton se désactive
                }
            }

            if (canvasMagieNoir2.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieCLv0 * (mageNoirs / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    C_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieCLv0 * (mageNoirs / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    C_btn.interactable = false; // le bouton se désactive
                }
            }
            if (canvasMagieNoir3.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieCLv0 * (mageNoirs / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    C_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieCLv0 * (mageNoirs / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    C_btn.interactable = false; // le bouton se désactive
                }
            }
            if (canvasMagieNoir4.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieCLv0 * (mageNoirs / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    C_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieCLv0 * (mageNoirs / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    C_btn.interactable = false; // le bouton se désactive
                }
            }

            //Canvas Invocation

            if (canvasInvocation1.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieDLv0 * (invocateurs / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    D_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieDLv0 * (invocateurs / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    D_btn.interactable = false; // le bouton se désactive
                }
            }
            if (canvasInvocation2.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieDLv0 * (invocateurs / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    D_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieDLv0 * (invocateurs / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    D_btn.interactable = false; // le bouton se désactive
                }
            }
            if (canvasInvocation3.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieDLv0 * (invocateurs / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    D_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieDLv0 * (invocateurs / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    D_btn.interactable = false; // le bouton se désactive
                }
            }
            if (canvasInvocation4.activeSelf == true)
            {
                if (Scr_XP.Scr_XPStatic.xp >= (prixMagieDLv0 * (invocateurs / 10 + 1)) && A_btn.interactable == false) // Si j'ai assez d'argent et que le bouton est désactivé
                {
                    D_btn.interactable = true; // le bouton deviens actif
                }
                else if (Scr_XP.Scr_XPStatic.xp < (prixMagieDLv0 * (invocateurs / 10 + 1)) && A_btn.interactable == true) // Sinon, si le bouton est actif mais que je n'ai pas assez d'argent il redeviens inutilisable
                {
                    D_btn.interactable = false; // le bouton se désactive
                }
            }
        }
    }

    public void SwitchCanvasApparition()
    {
        if (Input.GetMouseButtonUp(0) && Canvas.activeSelf == true)
        {
            Debug.Log("Clic");
            Canvas.SetActive(false);//Désaffiche le canvas



        }
        else if (Input.GetMouseButtonUp(0) && Canvas.activeSelf == false)
        {
            Debug.Log("active");
            Canvas.SetActive(true); //Affiche le canvas d'amélioration
                                    //Canvas.transform.position = Scr_Emplacement.positionnement;


        }

    }

    public void MagieA()
    {


        if (A_btn_confirm.activeSelf == true) // si le bouton valider est activé
        {
            if (Scr_XP.Scr_XPStatic.xp >= prixMagieALv0)
            {
                Scr_XP.Scr_XPStatic.xp = Scr_XP.Scr_XPStatic.xp - prixMagieALv0;
                Instantiate(fireStudent, pos, Quaternion.identity).transform.gameObject.tag = "1";
                //Scr_Emplacement.Scr_Emplacement_static.niveau = 1;


                SwitchCanvasApparition();
                A_btn_confirm.SetActive(false);

            }
        }
        else // si le bouton valider est désactivé
        {
            A_btn_confirm.SetActive(true); // on l'active
        }
    }
    public void MagieB()
    {
        if (B_btn_confirm.activeSelf == true) // si le bouton valider est activé
        {
            if (Scr_XP.Scr_XPStatic.xp >= prixMagieBLv0)
            {
                Scr_XP.Scr_XPStatic.xp = Scr_XP.Scr_XPStatic.xp - prixMagieBLv0;
                Instantiate(poisonStudent, pos, Quaternion.identity).transform.gameObject.tag = "1";
                Scr_Emplacement.Scr_Emplacement_static.niveau = 1;
                SwitchCanvasApparition();
                B_btn_confirm.SetActive(false);

            }
        }
        else // si le bouton valider est désactivé
        {
            B_btn_confirm.SetActive(true); // on l'active
        }
    }
    public void MagieC()
    {
        if (C_btn_confirm.activeSelf == true) // si le bouton valider est activé
        {
            if (Scr_XP.Scr_XPStatic.xp >= prixMagieCLv0)
            {
                Scr_XP.Scr_XPStatic.xp = Scr_XP.Scr_XPStatic.xp - prixMagieCLv0;
                Instantiate(explosionStudent, pos, Quaternion.identity).transform.gameObject.tag = "1"; ;
                Scr_Emplacement.Scr_Emplacement_static.niveau = 1;
                SwitchCanvasApparition();
                C_btn_confirm.SetActive(false);

            }
        }
        else // si le bouton valider est désactivé
        {
            C_btn_confirm.SetActive(true); // on l'active
        }
    }
    public void MagieD()
    {
        if (D_btn_confirm.activeSelf == true) // si le bouton valider est activé
        {
            if (Scr_XP.Scr_XPStatic.xp >= prixMagieDLv0)
            {
                Scr_XP.Scr_XPStatic.xp = Scr_XP.Scr_XPStatic.xp - prixMagieDLv0;
                Instantiate(invocationStudent, pos, Quaternion.identity).transform.gameObject.tag = "1"; ;
                Scr_Emplacement.Scr_Emplacement_static.niveau = 1;
                SwitchCanvasApparition();
                D_btn_confirm.SetActive(false);

            }
        }
        else // si le bouton valider est désactivé
        {
            D_btn_confirm.SetActive(true); // on l'active
        }
    }





}





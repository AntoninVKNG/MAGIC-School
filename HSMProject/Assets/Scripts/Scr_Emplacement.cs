using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Emplacement : MonoBehaviour
{
    public static Scr_Emplacement Scr_Emplacement_static;
    public static Vector3 positionnement;
    public GameObject go_this;
    public  int niveau = 0; //niveau de 0-16
    
    void Start()

    {
        Scr_Emplacement_static = this;
    }

    void Update()
    {
        
    }
    public void OnMouseUp()
    {
        //Base
        Scr_Student.pos = this.transform.position;
        Scr_Student.Scr_StudentStatic.Canvas.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.Canvas.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        
        //Fire
        Scr_Student.Scr_StudentStatic.canvasFire1.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasFire1.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasFire2.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasFire2.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasFire3.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasFire3.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasFire4.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasFire4.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        //Alchimie
        Scr_Student.Scr_StudentStatic.canvasAlchimie1.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasAlchimie1.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasAlchimie2.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasAlchimie2.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasAlchimie3.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasAlchimie3.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasAlchimie4.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasAlchimie4.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        //MagieNoire
        Scr_Student.Scr_StudentStatic.canvasMagieNoir1.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasMagieNoir1.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasMagieNoir2.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasMagieNoir2.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasMagieNoir3.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasMagieNoir3.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasMagieNoir4.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasMagieNoir4.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        //Invocation
        Scr_Student.Scr_StudentStatic.canvasInvocation1.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasInvocation1.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasInvocation2.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasInvocation2.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasInvocation3.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasInvocation3.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        Scr_Student.Scr_StudentStatic.canvasInvocation4.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.canvasInvocation4.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);


        
        go_this = this.gameObject;
        Scr_Student.Scr_StudentStatic.go_Emplacement = go_this;
        Scr_Student.Scr_StudentStatic.DetectionLevel();
        
    }

}

        
 


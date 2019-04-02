<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Emplacement : MonoBehaviour
{
    public static Scr_Emplacement Scr_Emplacement_static;
    public static Vector3 positionnement;
    public  int niveau = 0; //niveau de 0-16



    
    void Start()
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Emplacement : MonoBehaviour
{
    public static Scr_Emplacement Scr_Emplacement_static;
    public static Vector3 positionnement;
    public GameObject go_this;
    public  int niveau = 0; //niveau de 0-16
    
    void Start()
>>>>>>> master
    {
        Scr_Emplacement_static = this;
    }

    void Update()
    {
        
    }
    public void OnMouseUp()
    {

        Scr_Student.pos = this.transform.position;
        Scr_Student.Scr_StudentStatic.Canvas.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.Canvas.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
<<<<<<< HEAD
        Scr_Student.Scr_StudentStatic.SwitchCanvasApparition();
        //Scr_Student.Scr_StudentStatic.DetectionLevel();
       // Debug.Log("switch");


    }

}
=======
        // Scr_Student.Scr_StudentStatic.SwitchCanvasApparition();
        go_this = this.gameObject;
        Scr_Student.Scr_StudentStatic.go_Emplacement = go_this;
        Scr_Student.Scr_StudentStatic.DetectionLevel();
        // Debug.Log("switch");
    }
}
>>>>>>> master

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Emplacement : MonoBehaviour
{

    public static Vector3 positionnement;

    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnMouseUp()
    {

        Scr_Student.pos = this.transform.position;
        Scr_Student.Scr_StudentStatic.Canvas.transform.position = positionnement;
        Scr_Student.Scr_StudentStatic.Canvas.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        Scr_Student.Scr_StudentStatic.SwitchCanvasApparition();
        
        Debug.Log("switch");


    }

}

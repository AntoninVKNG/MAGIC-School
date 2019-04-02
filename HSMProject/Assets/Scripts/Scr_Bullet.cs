using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Scr_Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public static int attackDamageMin = 4;
    public static int attackDamageMax = 6;
<<<<<<< HEAD
    //ennemy health;
    GameObject Ennemy;
    
=======
    //Scr_Enemy health;
    GameObject Scr_Enemy;
>>>>>>> master


    private void Awake()
    {
<<<<<<< HEAD
        Ennemy = GameObject.FindGameObjectWithTag("Enemy");
        
        //health = GetComponent<ennemy>();
=======
        Scr_Enemy = GameObject.FindGameObjectWithTag("Enemy");
        //health = GetComponent<Scr_Enemy>();
>>>>>>> master
    }

    public void Seek (Transform _target)
    {
        target = _target;
    }
    

    
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;

        }

        
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;


        transform.Translate(dir.normalized * distanceThisFrame, Space.World);

        
           
     

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Debug.Log("HIT YOU BRO");
        }
    }




}



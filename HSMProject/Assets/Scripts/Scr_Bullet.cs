using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Scr_Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public static int attackDamageMin = 4;
    public static int attackDamageMax = 6;
    //ennemy health;
    GameObject Ennemy;


    private void Awake()
    {
        Ennemy = GameObject.FindGameObjectWithTag("Enemy");
        //health = GetComponent<ennemy>();
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



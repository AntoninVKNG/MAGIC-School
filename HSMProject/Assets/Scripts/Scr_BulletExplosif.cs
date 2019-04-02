using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Scr_BulletExplosif : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public static int attackDamageMin = 20;
    public static int attackDamageMax = 20;
    
    public GameObject impactEffect;
    public float explosionRadius = 0f;
    //Scr_Enemy health;
    GameObject Scr_Enemy;


    private void Awake()
    {
        Scr_Enemy = GameObject.FindGameObjectWithTag("Enemy");
        //health = GetComponent<Scr_Enemy>();
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
            GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 2f);
           /* if (explosionRadius > 0f)
            {
               
            }*/ 
            Destroy(gameObject);
            Debug.Log("HIT YOU BRO");
        }

    }
  /*  void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach  (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }

    }*/
    

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }


}



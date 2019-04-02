using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BulletMN : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public static int attackDamageMin = 5;
    public static int attackDamageMax = 7;

    //ennemy health;
    GameObject Ennemy;


    //Scr_Enemy health;
    GameObject Scr_Enemy;



    private void Awake()
    {

        Ennemy = GameObject.FindGameObjectWithTag("Enemy");

        //health = GetComponent<ennemy>();

        Scr_Enemy = GameObject.FindGameObjectWithTag("Enemy");
        //health = GetComponent<Scr_Enemy>();

    }

    public void Seek(Transform _target)
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

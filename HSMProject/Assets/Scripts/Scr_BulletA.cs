using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BulletA : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public static int attackDamageMin = 1;
    public static int attackDamageMax = 1;
    //ennemy health;
    GameObject Ennemy;


    private void Awake()
    {
        Ennemy = GameObject.FindGameObjectWithTag("Enemy");
        //health = GetComponent<ennemy>();
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
            Debug.Log("You Out of Mana");
        }
    }

}

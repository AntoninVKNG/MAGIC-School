using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turret : MonoBehaviour {

    private Transform target;
    private Scr_Enemy targetEnemy;
    public float range;
    public string enemyTag = "Scr_Enemy";
    public Transform partToRotate;
    public float turnSpeed = 10f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float timeBetweenAttacks = 0.8f;
    float shortestDistance = Mathf.Infinity;
    private GameObject nearestEnemy = null;
    private float distanceToEnemy;
    public GameObject[] enemies;

    void Start () {
        InvokeRepeating("UpdateTarget", 0f, timeBetweenAttacks);

	}
	
	void UpdateTarget()
    {

        





        // visée

        //enemies = GameObject.FindGameObjectsWithTag("Enemy"); //détecte le tag dans la scène



        /*foreach (GameObject Enemy in enemies) //pour chaque Enemy dans la liste ennemies
        {
            Debug.Log("Pour chaque ennemies");

            float distanceToEnemy = Vector3.Distance(transform.position, Enemy.transform.position); //distanceToEnemy = la distance entre la position de la tour et l'ennemi
            if (distanceToEnemy < shortestDistance) 
            {
                shortestDistance = distanceToEnemy; //la distance le plus petite = la distance de l'ennemi
                nearestEnemy = Enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            
           
        } */
    }

    

    void Update ()
    {
        

        //if (target == null)
            //return;

        //Target Lock On


        LockTarget();


        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = fireRate;
        }
        else
        fireCountdown -= Time.deltaTime;

        


	}

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger");

        if (other.gameObject.tag == "Enemy" )
        {
            
            nearestEnemy = other.gameObject;
            target = nearestEnemy.transform;
            targetEnemy = nearestEnemy.GetComponent<Scr_Enemy>();

            Debug.Log("Il tire !");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == targetEnemy.gameObject)
        {
            nearestEnemy = null;
            targetEnemy = null;
            target = null;
        }
    }

    void LockTarget() //rotation
    {
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }

    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Scr_Bullet bullet = bulletGo.GetComponent<Scr_Bullet>();

        if (bullet != null && target != null)
            bullet.Seek(target);
    }

    private void OnDrawGizmosSelected() // range visuelle
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }


}

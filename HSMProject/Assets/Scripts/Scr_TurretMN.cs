using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_TurretMN : MonoBehaviour
{
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

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, timeBetweenAttacks);

    }

    void UpdateTarget()
    {


    }



    void Update()
    {                      
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

        if (other.gameObject.tag == "Enemy")
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
        Scr_BulletMN bullet = bulletGo.GetComponent<Scr_BulletMN>();

        if (bullet != null && target != null)
            bullet.Seek(target);
    }

    private void OnDrawGizmosSelected() // range visuelle
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}

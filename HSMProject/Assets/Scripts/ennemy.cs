﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ennemy : MonoBehaviour
{
    public static ennemy Scr_ennemyStatic;
    public float speed = 10f;
    public float health;
    public float currentHealth;
    public Image healthBar;
    bool damaged;
    bool isDead;
    private Transform target;
    private int wavepointIndex = 0;

    public void OnEnable()
    {
        currentHealth = health;
    }
    private void Awake()
    {
       
        Scr_ennemyStatic = this;
    }

    private void Start()
    {
        target = Waypoints.points[0];

    }

    private void Update()
    {
        
        healthBar.fillAmount = currentHealth / health;
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            TakeDamage(Random.Range(Scr_Bullet.attackDamageMin, Scr_Bullet.attackDamageMax));
            Debug.Log("HIT YOU BRO");
        }

        if (other.gameObject.tag == "BulletExplosif")
        {

            TakeDamage(Random.Range(Scr_BulletExplosif.attackDamageMin, Scr_BulletExplosif.attackDamageMax));
            Debug.Log("HIT YOU BRO");
        }
    }

    public void TakeDamage(float amount)
    {
        Debug.Log("hit");
        //Debug.Log(currentHealth);
        currentHealth = currentHealth - amount ;
        Debug.Log(currentHealth);

        
        if (currentHealth < health)
        {
            damaged = true;
        }
        

        if (currentHealth <= 0 && !isDead)
        {
            Death();
            Debug.Log("il est mort");
        }

        void Death()
        {
            isDead = true;
            Debug.Log("ennemis morts");
            Destroy(gameObject);
        }

    }

}
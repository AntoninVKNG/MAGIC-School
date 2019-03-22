using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_GoldenStudent : MonoBehaviour
{
    public Transform target;
    public GameObject studentBalais;
    public float rotationMin;
    public float rotationMax;
    public Transform spawnMin;
    public Transform spawnMax;
    public Vector3  amplitudeMin;
    public Vector3 amplitudeMax;
    public Vector3 positionTemp;
    public float vitesse;
    public bool spawnEnable = true;
    public int tempsMin;
    public int tempsMax;

    void Start()
    {

        amplitudeMin = spawnMin.transform.position;
        amplitudeMax = spawnMax.transform.position;
        if (spawnEnable == true)
        {
            spawnEnable = false;
            StartCoroutine("SpawnDelay");
        }
        
    }

    void Update()
    {
        if (gameObject.name == "GoldenStudent(Clone)")
        {
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * vitesse * Time.deltaTime, Space.World);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Target")
        Destroy(gameObject);
    }
    public void OnMouseDown()
    {
        Scr_Clicker.Scr_ClickerStatic.BoostXpGoldenStudent();
        Destroy(gameObject);
    }

    IEnumerator SpawnDelay()
    {
        yield return new WaitForSecondsRealtime(Random.Range(tempsMin,tempsMax));
        
        positionTemp = new Vector3(Random.Range(amplitudeMin.x, amplitudeMax.x), Random.Range(amplitudeMin.y, amplitudeMax.y), Random.Range(amplitudeMin.z, amplitudeMax.z));
        GameObject clone = Instantiate(studentBalais, positionTemp, transform.rotation);
        StartCoroutine("SpawnDelay");
    }

   



}

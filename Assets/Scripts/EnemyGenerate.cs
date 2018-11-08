using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour
{
    public GameObject barrel;
    private float Xmin = -20.0f;
    private float Xmax = 15.0f;
    private float Zmin = 0.0f;
    private float Zmax = 20.0f;
    private float generateHeight = 20.0f;
    private float startTime = 0.5f;
    private float generateRate = 0.5f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("BarrelGenerating", startTime, generateRate);
    }

    void BarrelGenerating()
    {
        float randomX = Random.Range(Xmin, Xmax);
        float randomZ = Random.Range(Zmin, Zmax);
        Instantiate(barrel, new Vector3(randomX, generateHeight, randomZ), barrel.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

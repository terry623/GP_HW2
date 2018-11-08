using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerate : MonoBehaviour
{
    public GameObject mushroom;
    public GameObject barrel;
    public GameObject rock;
    private GameObject[] items;

    private float Xmin = -40.0f;
    private float Xmax = 20.0f;
    private float Zmin = -5.0f;
    private float Zmax = 50.0f;
    private float generateHeight = 30.0f;
    private float startTime = 0.5f;
    private float generateRate = 0.5f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("ItemGenerating", startTime, generateRate);
        items = new GameObject[] { mushroom, barrel, rock };
    }

    void ItemGenerating()
    {
        for (int i = 0; i < items.Length; i++)
        {
            float randomX = Random.Range(Xmin, Xmax);
            float randomZ = Random.Range(Zmin, Zmax);
            Instantiate(items[i], new Vector3(randomX, generateHeight, randomZ), items[i].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

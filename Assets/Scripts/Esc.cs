using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc : MonoBehaviour
{
    public Canvas escCanvas;
    public Canvas scoreCanvas;
    public Light sun;
    public GameObject grandpa;
    public GameObject grandma;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            escCanvas.enabled = !escCanvas.enabled;
            scoreCanvas.enabled = !scoreCanvas.enabled;
        }
    }

    public void ModifyLight(float vol)
    {
        sun.intensity = vol;
    }

    public void ChangePeople(int idx)
    {
        if (idx == 0)
        {
            grandpa.SetActive(true);
            grandma.SetActive(false);
			grandpa.transform.position = grandma.transform.position;
        }
        else
        {
            grandma.SetActive(true);
            grandpa.SetActive(false);
			grandma.transform.position = grandpa.transform.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc : MonoBehaviour
{
    public Canvas escCanvas;
    public Canvas scoreCanvas;
    public Light sun;

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
}

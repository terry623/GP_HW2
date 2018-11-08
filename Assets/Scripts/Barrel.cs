using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public UI manager;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 100.0f, Space.World);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "player")
        {
            manager.addScore(false);
            Destroy(this.gameObject);
        }
    }
}

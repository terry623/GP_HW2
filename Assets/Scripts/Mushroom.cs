using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
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
        if (other.gameObject.tag == "player") Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private float windForce = 20.0f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("MovedByWind", 0.0f, 0.2f);
    }

    void MovedByWind()
    {
        if (Random.Range(0.0f, 1.0f) > 0.5f) GetComponent<Rigidbody>().AddForce(Vector3.right * windForce);
        else GetComponent<Rigidbody>().AddForce(-1 * Vector3.right * windForce);
    }

    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 100.0f, Space.World);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "env") Destroy(this.gameObject);
    }
}

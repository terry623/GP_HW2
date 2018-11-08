using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public UI manager;
    public AudioSource _audioSource;
    public Object ExplosionEffect;

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
             Destroy(this.gameObject, 1);
        }
        else if (other.gameObject.tag == "player")
        {
            manager.addScore(false);
            _audioSource.Play();

            GameObject exp = GameObject.Instantiate(ExplosionEffect, Vector3.zero, Quaternion.identity) as GameObject;
            exp.transform.position = gameObject.transform.position;

            Destroy(this.gameObject);
        }
    }
}

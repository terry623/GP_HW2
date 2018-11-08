﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float velocity = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.back * velocity);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.right * velocity);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.forward * velocity);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.left * velocity);
    }
}

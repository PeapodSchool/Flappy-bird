﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    [SerializeField] float velocity = 1f;
    Rigidbody2D rb;
    private bool isAlreadyTouched = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isAlreadyTouched == false)
        {
            isAlreadyTouched = true;
            rb.isKinematic = false;
            FindObjectOfType<PipeSpawner>().StartSpawning();
            rb.velocity = Vector2.up * velocity;
        }
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
}

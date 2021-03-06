﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestSyntax : MonoBehaviour
{
    
    public Rigidbody2D rBody;

    [Header("Flip Test")]
    public bool bool1 = false;
    public bool bool2 = true;
    public float rotation = 0f;
    public float speed = 1f;
    public float fullSpeed = 10f;

    [Header("Timer")]
    public float timer = 0.0f;

    private void Start()
    {
        rBody.velocity = transform.right * speed * Time.deltaTime;
    }


    private void Update()
    {
        //Rotation();
        Timer();
    }

    void Rotation()
    {
        bool1 = !bool2;
        
        transform.rotation = Quaternion.Euler(0, 0, rotation);

        if (bool1)
        {
            rotation -= Time.deltaTime * speed;            
        }

        else
        {
            if(rotation < -1)
            {           
                if (rotation > -100)
                {
                    rotation += Time.deltaTime * fullSpeed;
                }
                if (rotation < -90)
                {
                    rotation -= Time.deltaTime * fullSpeed;
                }                                
            }
            else
            {
                rotation = 0;
            }
        }

        if (rotation <= -360f)
        {
            rotation = 0;
        }

    }

    int Timer()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        int seconds = Convert.ToInt32(timer);
        Debug.Log(seconds);
        return seconds;
    }

}

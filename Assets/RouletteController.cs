﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotspeed = 0.0f;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 10.0f;
        }
        transform.Rotate(0, 0, this.rotspeed);
        if(Input.GetMouseButtonDown(1))
        {
            this.rotspeed = 0.0f;
        }
        rotspeed = this.rotspeed * 0.987f;
    }
}

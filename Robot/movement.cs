﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private int direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -3) { direction = 1; }
        if (transform.position.z > 3) { direction = -1; }
        transform.position += new Vector3(0, 0, direction * Time.deltaTime);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float timeLeft = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                print("lose lol");
            }
    }
}

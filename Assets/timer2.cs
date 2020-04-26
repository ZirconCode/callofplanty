using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer2 : MonoBehaviour
{

    public mainstuff wow;

    public double seconds;

    bool enabled = true;

    // Start is called before the first frame update
    void Start()
    {
        //cam.atta
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if(seconds < 0 && enabled)
        {
            enabled = false;
            dothing();
        }
    }

    void dothing()
    {
        wow.makediver();
    }

}

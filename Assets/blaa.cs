using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blaa : MonoBehaviour
{

    float time = 0;

    public List<(double, bool)> evs = new List<(double, bool)>();


    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        evs.Add((15, true));
        evs.Add((20, false));
        evs.Add((50, true));
        evs.Add((60, false));
        evs.Add((90, true));
        evs.Add((120, false));
        evs.Add((160, true));
        evs.Add((180, false));
        evs.Add((200, true));
  

        evs.Add((20000, true));

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
       // print(time);

        if (evs[0].Item1 < time)
        {
            print(evs[0]);
            anim.SetBool("angry", evs[0].Item2);
            evs.RemoveAt(0);
        }

      
            
    }
}

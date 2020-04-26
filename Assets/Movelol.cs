using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movelol : MonoBehaviour
{
    //public Sprite bla;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position.Set(50, 0, 0);
        transform.position += -transform.right * 2 * Time.deltaTime;

        //print(transform.position.x);
        if(transform.position.x < -17)
        {
            //print("wtf");
            //transform.position.Set(17, 2, 0);
            transform.position += transform.right * 34;
        }
            
    }
}

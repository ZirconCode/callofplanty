using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodey : MonoBehaviour
{

    public mainstuff amazing;

    // Start is called before the first frame update
    void Start()
    {
        Camera a = Camera.main;
        amazing = a.GetComponent<mainstuff>();
    }

    public void die()
    {
        print("wow");
        amazing.remLife(20);

    }

    public void endit()
    {
        Object.Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

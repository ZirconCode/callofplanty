using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
    float desiredScale = 1.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position +=  transform.up * Time.deltaTime;
        desiredScale *= 1.01f;// * Time.deltaTime; // your scale factor

        transform.localScale = new Vector3(desiredScale, desiredScale, desiredScale);
    }
}

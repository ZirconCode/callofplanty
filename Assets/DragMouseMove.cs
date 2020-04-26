using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMouseMove : MonoBehaviour {

    private Vector3 mousePosition;
    private SpriteRenderer rb;
  //  private Vector2 direction;
  //  private float moveSpeed = 100f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 3;
        rb.transform.position = mousePosition;
     //   print(mousePosition);
    }
}

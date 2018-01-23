using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_zappa : MonoBehaviour {

    public int speed;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
    }

    // Update is called once per frame
    void Update () {
		
	}
}

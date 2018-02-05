using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 10;


      private int timeCount;
    

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

    }

    // Update is called once per frame
    void Update () {
        timeCount += 1;
      
        Destroy(this.gameObject, 1.5f);
    }
}

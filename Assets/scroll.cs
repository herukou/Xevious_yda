using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

    [SerializeField]
    public float moveSpeed;
    [SerializeField]
    private float this_x;

    /*// Use this for initialization
    void Start () {
		
	}*/
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, +moveSpeed, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Ship ship;

	// Use this for initialization
	void Start () {

        ship = GetComponent<Ship>();

    }

    public void OnTriggerEnter2D(Collider2D c)
    {
        ship.Explosion();

        Destroy(gameObject);
    }
}

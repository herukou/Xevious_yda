using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    Ship ship;

    void Start()
    {
        ship = GetComponent<Ship>();

        ship.Move(transform.up * -1);
    }

    public void OnTriggerEnter2D(Collider2D c)
    {
        ship.Explosion();

        Destroy(gameObject);
    }
}

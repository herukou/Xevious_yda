using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_B : MonoBehaviour {

    Enemy_SS Enemy_SS;

    void Start()
    {
        Enemy_SS = GetComponent<Enemy_SS>();
    }

    public void OnTriggerEnter2D(Collider2D c)
    {
        Enemy_SS.Explotion();

        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarken_e : MonoBehaviour {

    Tarken_s Tarken_s;

    void Start()
    {
        Tarken_s = GetComponent<Tarken_s>();
    }

    public void OnTriggerEnter2D(Collider2D c)
    {
        Tarken_s.Explotion();

        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    Enemy_S Enemy_S;

    public void OnTriggerEnter2D(Collider2D c)
    {
        Enemy_S.Explosion();

        Destroy(gameObject);
    }
}

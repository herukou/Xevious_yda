using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ship : MonoBehaviour {

    //スピード
    public float speed;

    //間隔
    public float shotDelay;

    //弾
    public GameObject bullet;

    //爆発
    public GameObject explosion;


    //爆発作成
    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }


    public void Shot (Transform origin)
    {
        Instantiate(bullet, origin.position, origin.rotation);
    }


    public void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

}

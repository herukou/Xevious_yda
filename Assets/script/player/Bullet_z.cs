using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_z : MonoBehaviour {


    public GameObject zappaPrefab;
    public int speed = 5;


    private AudioSource FireSound_z;


    private int timeCount;

    void Start()
    {
        FireSound_z = GetComponent<AudioSource>();
    }




    void Update () {


        timeCount += 1;

        if (Input.GetButton("Fire1"))
        {

         
            if (timeCount % 8 == 0)     //--ここの値で発射間隔をいじる
            {

                // プレハブからザッパ―オブジェクトを作成し、それをzappaという名前の箱に入れる。
                GameObject zappa = Instantiate(zappaPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);

                //Vector3 force;
                //force = this.gameObject.transform.forward * speed;


                //AudioSource.PlayClipAtPoint(fireSound, transform.position);

                FireSound_z.PlayOneShot(FireSound_z.clip);

                Destroy(zappa, 2.0f);
            }
        }

    }


}

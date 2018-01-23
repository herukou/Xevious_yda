using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_b : MonoBehaviour {
    
    //プレハブ
    public GameObject BlasterPrefab;
    public GameObject Aim_PointPrefab;

    

    private AudioSource FireSound_b;

    private GameObject Blaster;
    private GameObject Point;

    private int Blaster_Flg = 1;


    void Start()
    {

        FireSound_b = GetComponent<AudioSource>();

    }   

    void Update()
    {


        if (Input.GetButton("Fire2"))
        {


            if (Blaster_Flg == 1)     //--ここの値で発射間隔をいじる
            {
                Blaster_Flg *= -1;

             // プレハブからブラスターオブジェクトを作成し、それをBlasterという名前の箱に入れる。
              Blaster = Instantiate(BlasterPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
             // プレハブからPointオブジェクトを作成し、それをPointという名前の箱に入れる。
              Point = Instantiate(Aim_PointPrefab, new Vector2(transform.position.x, transform.position.y + 6), Quaternion.identity);

               

             //Vector3 force;
             //force = this.gameObject.transform.forward * speed;

             FireSound_b.PlayOneShot(FireSound_b.clip);


            }
        }
        if (!FireSound_b.isPlaying)
        {
            Destroy(Blaster);
            Destroy(Point);
            Blaster_Flg *= -1;
        }

    }


}

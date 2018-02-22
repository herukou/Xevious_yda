using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy_SS : MonoBehaviour
{


    // 弾のPrefab
    public GameObject bullet;

    private GameObject target;

    //爆発
    public GameObject explotion;

    public int rand;

    float cnt;


    //爆発作成
    public void Explotion()
    {
        Instantiate(explotion, transform.position, transform.rotation);
    }

    //自機狙い
    public float GetAim()
    {

        Vector2 p1 = transform.position;
        Vector2 p2 = target.transform.position;
        float dx = p2.x - p1.x;
        float dy = p2.y - p1.y;
        float rad = Mathf.Atan2(dy, dx);

        return rad * Mathf.Rad2Deg;
    }

    // 弾の作成
    public void Shot(Transform origin)
    {
        Instantiate(bullet, origin.position, origin.rotation);
    }



    // Use this for initialization
    void Start()
    {
        cnt = 0;
        //target = GameObject.Find("Player");

        //ランダムのタイミングのための
        rand = Random.Range(150, 250);

        
    }


    // Update is called once per frame
    void Update()
    {
        cnt++;

        target = GameObject.Find("Player");

        
         if (cnt % rand == 0)
            //if (cnt % 5 == 0)
            {
                /// 子要素を全て取得する
                for (int i = 0; i < transform.childCount; i++)
                {

                    Transform shotPosition = transform.GetChild(i);

                    shotPosition.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270f + GetAim());

                    // ShotPositionの位置/角度で弾を撃つ
                    Shot(shotPosition);
                }
         }
        

    }
}
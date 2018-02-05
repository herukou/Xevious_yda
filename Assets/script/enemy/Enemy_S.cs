using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy_S : MonoBehaviour {


    // 弾を撃つ間隔
    public float shotDelay;

    // 弾のPrefab
    public GameObject bullet;

    private GameObject target;

    int cnt = 0;

    //爆発
    public GameObject explotion;


    //爆発作成
    public void Explotion()
    {
        Instantiate(explotion, transform.position, transform.rotation);
    }


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
    IEnumerator Start()
    {
        target = GameObject.Find("Player");
        
            while (true)
            {
               
                /// 子要素を全て取得する
                    for (int i = 0; i < transform.childCount; i++)
                    {

                    Transform shotPosition = transform.GetChild(i);

                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f + GetAim());

                    // ShotPositionの位置/角度で弾を撃つ
                    Shot(shotPosition);
                    }


                // shotDelay秒待つ
                yield return new WaitForSeconds(shotDelay);
                
            }

        

    }
	// Update is called once per frame
	void Update () {
        cnt++;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        
    }
}
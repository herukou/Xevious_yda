using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarken : MonoBehaviour {

    // 速度
    public Vector2 speed = new Vector2(0.05f, 0.05f);
    // ターゲットとなるオブジェクト
    public GameObject targetObject;
    // ラジアン変数
    private float rad;
    private float rad2;
    // 現在位置を代入する為の変数
    private Vector2 Position;

    public int rand = 0;
    int flg = 0;
    int flg_m = 0;
    int cnt_m = 0;

   
        
    

    // Use this for initialization
    void Start()
    {
        //player取得
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        rand = Random.Range(50, 100);

        // ラジアン
        rad = Mathf.Atan2(
            targetObject.transform.position.y - transform.position.y,
            targetObject.transform.position.x - transform.position.x);


    }

    // Update is called once per frame
    void Update()
    {

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector2 p2 = targetObject.transform.position;
        Vector2 p1 = transform.position;

        cnt_m++;

        // ラジアン
        if (flg_m == 0) {
            rad2 = Mathf.Atan2(
            targetObject.transform.position.y - transform.position.y,
            targetObject.transform.position.x - transform.position.x);

        }
 
        if (flg == 0)
        {
            // 現在位置をPositionに代入
            Position = transform.position;
            Position.x += speed.x * Mathf.Cos(rad);
            Position.y += speed.y * Mathf.Sin(rad);
            // 現在の位置に加算減算を行ったPositionを代入する
            transform.position = Position;
        }

        if (cnt_m >= rand)
        {
                flg = 1;
                flg_m = 1;
                //Position.x -= -speed.x ;
                //Position.y -= speed.y;
                //transform.position = Position;
            if (flg == 1)
            {
                Position = transform.position;
                Position.x += -speed.x * Mathf.Cos(rad2);
                Position.y += -speed.y * Mathf.Sin(rad2);
                transform.position = Position;
            }

        }


    }
}

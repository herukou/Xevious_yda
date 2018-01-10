using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {


    // 速度
    public Vector2 speed = new Vector2(0.05f, 0.05f);
    // ターゲットとなるオブジェクト
    public GameObject targetObject;
    // ラジアン変数
    private float rad;
    // 現在位置を代入する為の変数
    private Vector2 Position;

    // Use this for initialization
    void Start () {

        //player取得
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // ラジアン
        rad = Mathf.Atan2(
            targetObject.transform.position.y - transform.position.y,
            targetObject.transform.position.x - transform.position.x);

    }

    // Update is called once per frame
    void Update () {

        // 現在位置をPositionに代入
        Position = transform.position;
        Position.x += speed.x * Mathf.Cos(rad);
        Position.y += speed.y * Mathf.Sin(rad);
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = Position;
    }
}

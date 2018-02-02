using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAKATOmove : MonoBehaviour {

    public Vector2 speed = new Vector2(0.05f, 0.05f);

    private Vector2 Position;

    // Use this for initialization
    void Start()
    {


        // ローカル座標のY軸のマイナス方向に移動する
       // .Move(transform.up * -1);
    }

    // Update is called once per frame
    void Update () {
        Position = transform.position;
        Position.x = speed.x + Position.x;
        Position.y = speed.y + Position.y;

        transform.position = Position;
    }
}

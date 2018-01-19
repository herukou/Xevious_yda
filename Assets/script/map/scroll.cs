using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

    [SerializeField]
    public float moveSpeed;
    [SerializeField]
    private float this_x;

    private Vector3 startPosition;
    public float border;
   // public float border2;

    // Use this for initialization
    void Start () {
        startPosition = transform.position;

    }

    // Update is called once per frame
    void Update () {
        transform.Translate(0, +moveSpeed, 0);

        Vector3 pos = transform.position;
        pos.z -= Time.deltaTime * 1;
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        // （ポイント）zの値が境界線以下になったら初期位置に戻す。
        if (pos.z <= border)
        {
            transform.position = startPosition;
        }
       /* if (pos.z <= border2)
        {
            transform.position = startPosition;

        }
        /*  int x=0,y=0;
            while(true)
            {


             break;
          }*/
    }
}

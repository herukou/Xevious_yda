﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mori : MonoBehaviour {
    private Vector3 startPosition;
    public float border;
    // Use this for initialization
    void Start () {
        startPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        

        Vector3 pos = transform.position;
        pos.z -= Time.deltaTime * 1;
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        // （ポイント）zの値が境界線以下になったら初期位置に戻す。
        if (pos.z <= border)
        {
            transform.position = startPosition;
        }
    }
}

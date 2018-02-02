using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim_Point : MonoBehaviour {

    public GameObject Aim_PointPrefab;


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2"))
        {
            // プレハブからザッパ―オブジェクトを作成し、それをzappaという名前の箱に入れる。
            GameObject Point = Instantiate(Aim_PointPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);

            Destroy(Point, 2.0f);
        }
    }
}

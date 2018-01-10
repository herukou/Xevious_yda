using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


    // 弾を撃つ間隔
    public float shotDelay;

    // 弾のPrefab
    public GameObject bullet;


    // 弾の作成
    public void Shot(Transform origin)
    {
        Instantiate(bullet, origin.position, origin.rotation);
    }


    // Use this for initialization
    IEnumerator Start()
    {
        while (true)
        {

            // 子要素を全て取得する
            for (int i = 0; i < transform.childCount; i++)
            {

                Transform shotPosition = transform.GetChild(i);

                // ShotPositionの位置/角度で弾を撃つ
                Shot(shotPosition);
            }

            // shotDelay秒待つ
            yield return new WaitForSeconds(shotDelay);
        }

    }
	// Update is called once per frame
	void Update () {
		
	}
}
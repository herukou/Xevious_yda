using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Broken : MonoBehaviour {

    private AudioSource BrokenAudio;
    public GameObject BrokenPrefab;
    private GameObject target;


    private GameObject Broken;

    int Broken_Flg = 1;

    int Destroy_Flg = 1;

    void Start()
    {
        //爆発サウンドを取得
        BrokenAudio = GetComponent<AudioSource>();
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update () {

        //this.gameObject.transform.LookAt(target.transform.position);

        if (Broken_Flg == 1)
        {
            if (!target)
            {
                Broken_Flg *= -1;
                Destroy_Flg *= -1;
                Broken = Instantiate(BrokenPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);

                BrokenAudio.PlayOneShot(BrokenAudio.clip);
            }
        }

        if (Destroy_Flg == -1)
        {
            //Broken.PlayOneShot(Broken.clip);
            if (!BrokenAudio.isPlaying)
            {
                Destroy(Broken);
            }
        }
    }
}

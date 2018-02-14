using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_mori : MonoBehaviour
{

    //    private new AudioSource  audio;
    private new AudioSource audio1;
    private new AudioSource  audio2;

    // Use this for initialization
    void Start()
    {

        AudioSource[] audioSources = GetComponents<AudioSource>();
        audio1 = audioSources[0];
        audio2 = audioSources[1];

        //audio1 = GetComponent<AudioSource>();
        //audio.Play();

        StartCoroutine(Checking(() =>
        {
            //Debug.Log("END");
            
            audio2.Play();
        }));

           
    }

    // Update is called once per frame
    void Update()
    {

    }
    public delegate void functionType();
    private IEnumerator Checking(functionType callback)
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            if (!audio1.isPlaying)
            {
                callback();
                break;
            }
        }

    }
}

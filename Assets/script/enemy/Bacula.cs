using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacula : MonoBehaviour {

    Bacula_k Bacura_k;

    void Start()
    {
        Bacura_k = GetComponent<Bacula_k>();

        Bacura_k.Move(transform.up * -1);
    }
}

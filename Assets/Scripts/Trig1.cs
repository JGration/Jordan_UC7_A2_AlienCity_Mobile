using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig1 : MonoBehaviour {

    public static bool range;

    private void Start()
    {
        range = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            range = true;
            Destroy(gameObject);
        }
    }
}

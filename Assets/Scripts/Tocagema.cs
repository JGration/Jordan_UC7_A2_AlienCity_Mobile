using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocagema : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            RotacionaPedra.scorepedra += 1;
            Destroy(gameObject);
        }
    }
}

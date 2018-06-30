using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap1 : MonoBehaviour {

    public static int lives = 2;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            lives -= 1;
            Destroy(col.gameObject);
            Timecounter.timeLeft = 40.0f;
            SceneManager.LoadScene("Jogo");
        }
    }
}

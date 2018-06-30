using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {

    public static bool gameoverOn;
    public Image img;

    void Start () {
        img.enabled = false;
        gameoverOn = false;
    }

    void Update () {
        if (Trap1.lives == -1 || Timecounter.timeLeft < 0)
        {
            img.enabled = true;
            gameoverOn = true;
            if (Input.GetKeyDown(KeyCode.R))
            {

                Trap1.lives += 3;
                Score.scorevalue = 0;
                img.enabled = false;
                gameoverOn = false;
                Timecounter.timeLeft = 40.0f;
                SceneManager.LoadScene("Jogo");
            }
        }
    }
}

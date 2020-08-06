using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject button, play, balls;
    int score = 0;

    public void ScoreUp() {
        score++;
        if (score == 4 ){
            Win();
        }
    }

    public void Win () {
        winText.SetActive(true);
        button.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game"); 
    }

    public void Play()
    {
        balls.SetActive(true);
        play.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    private int score;

    void Start() {
        score = 0;
    }
    public int IncrementScore(){
        score++;
        //Debug.Log("Score: " + score);
        if (score == 21)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        return score;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

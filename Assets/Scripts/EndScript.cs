using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Score.points = 0;
        AppleScore.ApplePoints = 0;
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
        Score.points = 0;
        AppleScore.ApplePoints = 0;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

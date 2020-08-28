using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);//começa o jogo
    }
    public void QuitGame()
    {
        Debug.Log("Game exit.");
        Application.Quit();
    }
    
}

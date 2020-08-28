using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool failed = false;
    public void GameOver()
    {
        if(failed == false)
        {
            failed = true;
            SceneManager.LoadScene(0);//retorna ao menu inicial quando falhar
        }
    }
}

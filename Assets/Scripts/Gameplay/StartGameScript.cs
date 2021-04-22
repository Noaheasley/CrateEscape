using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public string newGameScene;
    //loads up the game
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
}

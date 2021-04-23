using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    //loads up the game
    public void NewGame()
    {
        //loads up scene 1
        SceneManager.LoadScene(1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public delegate void GameEvent();

public class GameManagerBehaviour : MonoBehaviour
{
    [SerializeField]
    private static bool _gameOver = false;

    [SerializeField]
    private static bool _isPlayerDead = false;

    public static GameEvent OnGameOver;

    [SerializeField]
    private HealthBehaviour _playerHealth;
    [SerializeField]
    private HealthBehaviour _enemyHealth;
    [SerializeField]
    private GameObject _gameOverScreen;
    [SerializeField]
    private GameObject _deathScreen;

    public static bool GameOver
    {
        get
        {
            return _gameOver;
        }
    }

    public static bool PlayerDead
    {
        get
        {
            return _isPlayerDead;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        if (_playerHealth.Health <= 0)
        {
            _isPlayerDead = true;
            _deathScreen.SetActive(_isPlayerDead);
        }
        if (_enemyHealth.Health <= 0)
        {
            _gameOver = true;
            _gameOverScreen.SetActive(_gameOver);
        }
    }
}

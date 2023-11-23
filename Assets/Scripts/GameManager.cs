using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;
    private void Awake()
    {
        if (instance == null) instance = this;
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameResart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
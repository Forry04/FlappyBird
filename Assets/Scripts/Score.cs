using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{

    public static Score instance;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI bestScore;
    private int _score = 0;
    private int _bestScore = 0;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        score.text = _score.ToString();
        bestScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    public void ScoreUpdate()
    {
        _score++;
        score.text = _score.ToString(); 
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            bestScore.text = _score.ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text ScoreText;
    int score = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void addScore(bool isAdd)
    {
        if (isAdd) score += 1000;
        else score -= 1000;
        ScoreText.text = "得分：" + score.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score;
    public Text text;

    void Start()
    {
        text = GetComponent<Text>();
        score = PlayerPrefs.GetInt("CurrentScore");
    }

    private void Update()
    {
        if (score < 0)
            score = 0;
        text.text = "" + score;
    }

    public static void ChangeScore(int bludotValue)
    {
        score += bludotValue;
        PlayerPrefs.SetInt("CurrentScore", score);
    }
}

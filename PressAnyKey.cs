using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PressAnyKey : MonoBehaviour
{
    SceneLoader sceneLoader;

    public AudioSource menuSelect;

    void Update()
    {
        PlayerPrefs.SetInt("CurrentScore", ScoreManager.score);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            menuSelect.Play();
        }


    }
}

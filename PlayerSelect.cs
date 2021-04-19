using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{

    SceneLoader sceneLoader;

    public AudioSource menuSelect;

    void Update()
    {
        if (Input.GetButtonDown("Select 1"))
        {
            PlayerPrefs.SetInt("CurrentScore", 0);
            SceneManager.LoadScene(6);
            menuSelect.Play();
        }
        if (Input.GetButtonDown("Select 2"))
        {
            PlayerPrefs.SetInt("CurrentScore", 0);
            SceneManager.LoadScene(17);
            menuSelect.Play();
        }
    }
}

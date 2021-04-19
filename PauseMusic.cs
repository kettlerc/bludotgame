using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMusic : MonoBehaviour
{
    void Start()
    {
        MusicContinue.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }

}

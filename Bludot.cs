using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bludot : MonoBehaviour
{
    public int bludotValue = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.ChangeScore(bludotValue);
        }
    }
}

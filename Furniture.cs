using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    Level level;
    public int furnitureValue = 500;

    private void Start()
    {
        CountFurniture();
    }

    private void CountFurniture()
    {
        level = FindObjectOfType<Level>();
        if (tag == "Furniture")
        {
            level.CountFurniture();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.ChangeScore(furnitureValue);
            level.FurnitureCollected();

        }
         
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFurniture : MonoBehaviour
{
    public int maxFurniture = 5;
    public int minFurniture = 0;
    public int currentFurniture;
    public FurnitureBar furnitureBar;

    void Start()
    {
        currentFurniture = minFurniture;
        furnitureBar.SetMinFurniture(minFurniture);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Furniture"))
        {
            GiveFurniture(1);
        }
    }

    void GiveFurniture(int damage)
    {
        currentFurniture += damage;
        furnitureBar.SetFurniture(currentFurniture);
    }
}

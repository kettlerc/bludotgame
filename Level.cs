using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] int furnitureRemaining;
    [SerializeField] GameObject exitDoor;
    public AudioSource doorOpen;

    SceneLoader sceneLoader;
    Door door;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountFurniture()
    {
        furnitureRemaining++;
    }

    public void FurnitureCollected()
    {
        furnitureRemaining--;
        if (furnitureRemaining <= 0)
        {
            doorOpen.Play();
            exitDoor.GetComponent<Door>().OpenDoor();
        }
        
    }

}

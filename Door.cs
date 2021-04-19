using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    SceneLoader sceneLoader;
    Animator anim;
    [SerializeField]
    GameObject DoorType;
    int stateOfDoor = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetDoorState() == 2)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

    private void Start()
    {
        anim = GetComponent<Animator>();

        if (DoorType.name == "ExitDoor")
            ClosedDoor();
    }

    public void ClosedDoor()
    {
        if (DoorType.name == "ExitDoor")
        {
            anim.SetFloat("DoorState", 1);
            stateOfDoor = 1;
        }
    }

    public void OpenDoor()
    {
        if (DoorType.name == "ExitDoor")
        {
            anim.SetFloat("DoorState", 2);
            stateOfDoor = 2;
        }
    }

    public void SetDoorState(int state)
    {
        if (state == 1 && DoorType.name == "ExitDoor")
            ClosedDoor();
        if (state == 2 && DoorType.name == "ExitDoor")
            OpenDoor();
    }

    public int GetDoorState()
    {
        return stateOfDoor;
    }
}

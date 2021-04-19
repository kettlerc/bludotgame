using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCrate : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Ground"))
            transform.position = spawnPoint.position;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Enemy"))
            transform.position = spawnPoint.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInvulnerable : MonoBehaviour
{
    Renderer rend;
    Color c;

    void Start()
    {
        rend = GetComponent<Renderer>();
        c = rend.material.color;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Crate"))
        {
            StartCoroutine("GetInvulnerable");
        }
    }

    IEnumerator GetInvulnerable()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds(1f);
        Physics2D.IgnoreLayerCollision(8, 9, false);
        c.a = 1f;
        rend.material.color = c;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    [SerializeField] private float thrust;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D player = collision.GetComponent<Rigidbody2D>();
            if (player != null)
            {
                StartCoroutine(KnockCoroutine(player));
            }
        }
    }

    private IEnumerator KnockCoroutine(Rigidbody2D player)
    {
        Vector2 forceDirection = player.transform.position - transform.position;
        Vector2 force = forceDirection.normalized * thrust;

        player.velocity = force;
        yield return new WaitForSeconds(.1f);

        player.velocity = new Vector2();
    }
}



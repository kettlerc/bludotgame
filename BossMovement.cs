using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;
    public Transform groundDetection;
    public Rigidbody2D rb;
    public AudioSource crateHit;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 5f);
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.gameObject.CompareTag("Ground"))
        //{
        //    rb.velocity = new Vector2(0, 0);
        //    rb.AddForce(new Vector2(0, 15), ForceMode2D.Impulse);
        //}

        if (other.gameObject.CompareTag("Player"))
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

        if (other.gameObject.CompareTag("Crate"))
        {
            crateHit.Play();
        }
    }
}

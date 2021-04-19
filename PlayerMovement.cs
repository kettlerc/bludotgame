using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Level level;
    public CharacterController2D controller;
    public float runSpeed = 80f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public AudioSource collectBluDot;
    public AudioSource collectCoffee;
    public AudioSource collectFurniture;
    public AudioSource collectGoldCoin;
    public Animator animator;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bludot"))
        {
            collectBluDot.Play();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Coffee"))
        {
            collectCoffee.Play();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Furniture"))
        {
            collectFurniture.Play();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Gold Coin"))
        {
            collectGoldCoin.Play();
            Destroy(other.gameObject);
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("MovingPlatform"))
        {
            transform.parent = other.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("MovingPlatform"))
        {
            transform.parent = null;
        }
    }
}

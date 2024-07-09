using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 4f;
    private float jumpingPower = 10f;
    private bool isFacingRight = true;
    public Animator animationBool;
    private bool doubleJump;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private AudioSource jumpSound;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") != 0){
            animationBool.SetBool("isWalking", true);
        } else{
            animationBool.SetBool("isWalking", false);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if(isGrounded() && !Input.GetButton("Jump")){
            doubleJump = false;
        }

        if(Input.GetButtonDown("Jump")){
            if(isGrounded() || doubleJump){
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                doubleJump = !doubleJump;
                jumpSound.Play();
            }
        }

        if(isGrounded()){
            animationBool.SetBool("onAir", false);
        } else if(!isGrounded()){
            animationBool.SetBool("onAir", true);
        }

        if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        Flip();
    }

    private void FixedUpdate(){
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool isGrounded(){
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip(){
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f){
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    //public variables
    public int maxSpeed;
    public Transform groundCheck;
    public LayerMask defineGround;
    public float jumpForce = 50;
    //private variable
    private Rigidbody2D rBody;
    private SpriteRenderer sRender;
    private Animator animator;
    private bool isGrounded = false;
    private float groundRadius = 0.2f;

    // Use this for initialization
    void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        sRender = this.GetComponent<SpriteRenderer>();
        animator = this.GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Sprite3 Jump") > 0 && isGrounded)
        {
            animator.SetBool("ground", isGrounded);
            rBody.AddForce(new Vector2(0, jumpForce));
        }


    }

    //use for physics calculations
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, defineGround);
        //Debug.Log("is grounded?" + isGrounded);
        animator.SetBool("ground", isGrounded);
        animator.SetFloat("Vspeed", rBody.velocity.y);


        float moveHoriz = Input.GetAxis("Sprite3 Left Right");

        rBody.velocity = new Vector2(moveHoriz * maxSpeed, rBody.velocity.y);

        if (moveHoriz > 0)
        {
            sRender.flipX = false;
        }
        else if (moveHoriz < 0)
        {
            sRender.flipX = true;
        }

        animator.SetFloat("Speed", Mathf.Abs(moveHoriz));
    }
}

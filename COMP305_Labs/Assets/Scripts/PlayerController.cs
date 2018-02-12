using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //public variables
    public int maxSpeed;
    //private variable
    private Rigidbody2D rBody;
    private SpriteRenderer sRender;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        sRender = this.GetComponent<SpriteRenderer>();
        animator = this.GetComponent<Animator>();

    }
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");

        rBody.velocity = new Vector2(moveHoriz * maxSpeed, rBody.velocity.y);

        if (moveHoriz > 0)
        {
            sRender.flipX = false;
        }
        else if (moveHoriz < 0) {
            sRender.flipX = true;
        }

        animator.SetFloat("Speed", Mathf.Abs(moveHoriz));
    }
}

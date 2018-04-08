using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

    public float fallMultiplier;

    public float lowJumpMultiplier;

    public float jumpVelocity;

    public bool inAir = false;

    Rigidbody2D rb;

    Animator charAnim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        charAnim = GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && inAir == false)
        {
            rb.velocity = Vector2.up * jumpVelocity;
            inAir = true;
            charAnim.SetInteger("movementState", 2);
        }

        if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

        if (rb.velocity.y < 0)
        {
            //object is falling
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }


    }

    private void OnCollisionEnter2D()
    {
        inAir = false;
    }


}


/* original Jump Code
 
    if (Input.GetKey(KeyCode.Space))
         {
             rb.velocity = Vector2.up * jumpVelocity;
         }

        if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            inAir = true;
        }

    if (rb.velocity.y < 0)
        {
            //object is falling
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }

    */

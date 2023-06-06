using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour
{
    //Initialise Variables
    private Rigidbody2D rb;
    public float acceleration;
    public float jspeed;
    public int maxjumps;
    private int currentjumps;
    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        //Declare variables
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();

        currentjumps = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            //Add Negative rb Horizontal Velocity
            rb.velocity += new Vector2(-acceleration * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Add Positive rb Horizontal Velocity
            rb.velocity += new Vector2(acceleration * Time.deltaTime, 0);
        }


        if (IsGrounded() == true)
        {
            currentjumps = maxjumps;
            print("ruh");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentjumps > 0)
            {
                rb.velocity += new Vector2(0, jspeed);
                currentjumps -= 1;
            }
        }

    }
    private bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(collider.bounds.center, collider.bounds.size, 0f, Vector2.down, .1f);
        return raycastHit.collider;

    }
}
    
    

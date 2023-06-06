using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parkour : MonoBehaviour
{
    // -- Constants --
    private float acc;
    public float speed;
    public float jump_spd;

    private Rigidbody2D self;


    // Start is called before the first frame update
    void Start()
    {
        // Get Rigidbody property
        self = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float Move = Input.GetAxis("Horizontal");
        float up = Input.GetAxis("Vertical");

        if (up > 0) Jump(up);

        self.velocity = new Vector2(speed * Move, self.velocity.y);
    }

    void Jump(float up)
    {
        self.velocity = new Vector2(self.velocity.x, jump_spd*up);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    public float JumpForce;
    public float MaxVelocityY;
    public Rigidbody2D RigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            RigidBody2D.velocity = Vector2.zero;
            RigidBody2D.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

        }

        if (RigidBody2D.velocity.y > MaxVelocityY)
        {
            RigidBody2D.velocity = new Vector2(0, MaxVelocityY);
        }

    }
}

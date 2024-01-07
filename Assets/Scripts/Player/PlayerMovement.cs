using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5f; //movement speed
    Vector2 movement; //stores movement directions

    //player components
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        //move the player
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}

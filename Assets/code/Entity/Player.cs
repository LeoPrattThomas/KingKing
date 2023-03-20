using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Player 
-cords √
-movements √ (charcor animation after artests are ready)
-camera
*/

public class Player : MonoBehaviour
{
    
    // Start is called before the first frame update
    //movement
    public float moveSpeed = 5f;
    public Rigidbody2D rb;    
    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        //movement https://www.youtube.com/watch?v=whzomFgjT50
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    // This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    void FixedUpdate()
    {
        //movement https://www.youtube.com/watch?v=whzomFgjT50
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
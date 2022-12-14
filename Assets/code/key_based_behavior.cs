using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_based_behavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    float moveSpeed = 2;
        // Update is called once per frame

    //right
     if(Input.GetKey(KeyCode.D)){
        print("go left");
         GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
         
     }
    
    //left
     if(Input.GetKey(KeyCode.A)){
        print("go right");
         GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
         
     }

    //up
    if(Input.GetKey(KeyCode.W)){
        print("go up");
         GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.x);
         
     }

     //up
    if(Input.GetKey(KeyCode.S)){
        print("go down");
         GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.x);
 
     }

    //stop
    if(Input.GetKey(KeyCode.Space)){
        print("stop");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,GetComponent<Rigidbody2D>().velocity.x);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,GetComponent<Rigidbody2D>().velocity.y);

    }
    
    }
}
        //set each varible to 
        /*var direction_dict = new Dictionary<string, float>(){
            {"up",Vector3.up},
            {"w",Vector3.up},

            {"down", Vector3.down},
            {"s", Vector3.down},

            {"left", Vector3.left},
            {"a", Vector3.left},

            {"right", Vector3.right},
            {"d",Vector3.right},
        }; 
        foreach(var dirction in direction_dict){
            if (Input.GetKey(dirction.Key)){
                GetComponent<Rigidbody2D>().velocity += dirction.Value * speed * Time.deltaTime;
            }
       }
       */

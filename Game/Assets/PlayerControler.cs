using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Regidbody2D rb;
    
    Vector2 movement;

    void Update()
    {
       movement.x = Inpyt.GetAxisRaw("Horizontal");    
       movement.y = Inpyt.GetAxisRaw("Veetical");
    }


    void FixedUpdate(){

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }   



    
}   

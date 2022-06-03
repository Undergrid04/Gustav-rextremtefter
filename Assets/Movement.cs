using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 10f;     //Bashastigheten som vi har
    public float gravity = -9.82f; //acceleration som du faller i
    public float jumpHeight = 3f; //kraften som du flyger upp med
    
    public Transform GroundCheck;  
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded; 
    
    // Update is called once per frame
    void Update()
    {    //checkar om objektet �r i kontakt till marken
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);
       
        if(isGrounded && velocity.y < 0) 
        {
            velocity.y = -2f;        
        }  //kommando f�r s� att hastighet blir accelaration
        
        float x = Input.GetAxis("Horizontal");   
        float z = Input.GetAxis("Vertical");
        //s�ger att du kan r�ra dig p� x och z axeln. Character controller har redan tagit hand om inputs f�r basic movement
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)    //kan bara hoppa en g�ng per "marknudd" om man vill kalla det s�
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        //�kar fart n�r du h�ller i shift s� att du "springer"
        if (Input.GetKey("left shift"))
        {
            speed = 25f;
        }
        else
        {
            speed = 10f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

}

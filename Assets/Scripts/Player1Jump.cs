using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player1Jump : MonoBehaviour
{
    private Rigidbody _rb;
    
    //Variables
    public float Jumpforce = 35.0f;

    private bool grounded;
    private bool _jumpPressed = false;

    private bool isGrounded;
    private bool isJumping;
    private bool isFalling;

    private float _gravityValue = 9.81f;

    private Vector3 player1Input;

    public Animator _Anim;

   
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _Anim = GetComponent<Animator>();

    }

    //Read action
    public void onJump(){
        //Debug.Log("Jump pressed");

        //Check if no vertical movement
        if(_rb.velocity.y == 0){
            //Debug.Log("Can jump");
            _jumpPressed = true;
            _Anim.SetBool("IsJumping", true);
            isJumping = true;

        }
        else {
            //Debug.Log("Can't jump - In the air");
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Jump();

        Gravity();
    }

    void Jump(){

        grounded = _rb.velocity.y == 0;
        _Anim.SetBool("IsGrounded", true);
        isGrounded = true;
        _Anim.SetBool("IsJumping", false);
        isJumping = false;
        _Anim.SetBool("IsFalling", false);
        isFalling = false;

        if(_jumpPressed && grounded){
            
            _rb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
            grounded = false;
            _jumpPressed = false;
            _Anim.SetBool("IsGrounded", false);
            isGrounded = false;
            

        }
        

         
    }

    void Gravity(){

        _rb.AddForce(Vector3.up * -_gravityValue, ForceMode.Force);
        
        if(!_jumpPressed && !grounded){

            _Anim.SetBool("IsJumping", false);
            isJumping= false;
            _Anim.SetBool("IsFalling", true);
            isFalling= true;
             
        }

        if(!_jumpPressed && grounded)
        {
            _Anim.SetBool("IsFalling", false);
            isFalling = false;
            _Anim.SetBool("IsGrounded", true);
            isGrounded = true;

        }
    }
}

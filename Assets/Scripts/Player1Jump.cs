using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player1Jump : MonoBehaviour
{
    private Rigidbody _rb;
    
    //Variables
    public float Jumpforce = 40.0f;

    private bool grounded;
    private bool _jumpPressed = false;

    private float _gravityValue = 9.81f;

    private Vector3 player1Input;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    //Read action
    public void onJump(){
        //Debug.Log("Jump pressed");

        //Check if no vertical movement
        if(_rb.velocity.y == 0){
            //Debug.Log("Can jump");
            _jumpPressed = true;

        }else {
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
        

        if(_jumpPressed && grounded){
            
            _rb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
            grounded = false;
            _jumpPressed = false;
        }     
        
       
    }

    void Gravity(){

        _rb.AddForce(Vector3.down * _gravityValue, ForceMode.Force);
    }
}

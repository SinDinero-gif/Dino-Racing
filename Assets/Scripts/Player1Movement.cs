using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player1Movement : MonoBehaviour
{
    Vector2 player1Input;
    private float m_Speed;
    public float speedValue;
    GameObject Player1;

    public Animator _anim;
   

    

    private void Start(){

        _anim = GetComponent<Animator>();

        Player1 = GameObject.FindWithTag("Player1");
        
    }

    public void OnMove(InputAction.CallbackContext ctx){

        player1Input = ctx.ReadValue<Vector2>();
    }

   

    private void FixedUpdate(){

       
        MovePlayer();

        
        if (player1Input != Vector2.zero){

            m_Speed = speedValue;
        }

        
    }


    void MovePlayer(){

        Vector3 moveVector = player1Input.x * Vector3.right;
        moveVector.Normalize();

        _anim.SetFloat("PlayerHorizontal", player1Input.x);

        

        Player1.transform.Translate(moveVector * m_Speed * Time.deltaTime, Space.World);
        
    }

   
  
}

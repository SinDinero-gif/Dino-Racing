using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player2Movement : MonoBehaviour
{
    Vector2 player2Input;
    private float m_Speed;
    public float speedValue;
    public GameObject Player2;

    public Animator _anim;
   

    

    private void Start(){

        _anim = GetComponent<Animator>();

        Player2 = GameObject.FindWithTag("Player2");
        
    }

    public void OnMove(InputAction.CallbackContext ctx){

        player2Input = ctx.ReadValue<Vector2>();
    }

   

    private void FixedUpdate(){

       
        MovePlayer();

        
        if (player2Input != Vector2.zero){

            m_Speed = speedValue;
        }


        
    }


    void MovePlayer(){

        Vector3 moveVector = player2Input.x * Vector3.right;
        moveVector.Normalize();

        _anim.SetFloat("PlayerHorizontal", player2Input.x);

        

        Player2.transform.Translate(moveVector * m_Speed * Time.deltaTime, Space.World);
        
    }

    private void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == "Obstacle"){

            GameManager.health -= 1;
        }

    }

   
  
}

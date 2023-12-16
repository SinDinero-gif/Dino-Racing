using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float mSpeed = 10f;
    public SpawnManager spawnManager;

    void FixedUpdate(){
        
        float hMovement = Input.GetAxis("Horizontal") * mSpeed/2;
        float vMovement = Input.GetAxis("Vertical") * mSpeed;

        transform.Translate(new Vector3(hMovement,0f,vMovement)*Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other){
        spawnManager.SpawnTriggerEntered();
    }
}

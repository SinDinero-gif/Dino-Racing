using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float mSpeed = 10f;
    
    void FixedUpdate(){
        
        float hMovement = Input.GetAxis("Horizontal") * mSpeed/2;
        

        transform.Translate(new Vector3(hMovement,0f, 0f)*Time.deltaTime);
    }

  
}

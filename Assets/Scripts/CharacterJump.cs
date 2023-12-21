using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public float jumpForce = 10f;
    
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody _rb = GetComponent<Rigidbody>();
            _rb.AddForce(Vector3.up *  jumpForce, ForceMode.Impulse);
        }
    }
}

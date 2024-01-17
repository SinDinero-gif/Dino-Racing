using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2SimpleMovement : MonoBehaviour
{
    public float m_Speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput2 = Input.GetAxis("HorizontalPlayerTwo");
        
        transform.Translate(new Vector3(horizontalInput2,0f,0f)*m_Speed*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Obstacle2")
        {

            GameManagerPlayer2.healthPlayer2 -= 1;
        }

    }
}

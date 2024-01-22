using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1SimpleMovement : MonoBehaviour
{
    public float m_Speed = 10f;
    public Animator _Anim;

    private void Start()
    {
        _Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput1 = Input.GetAxis("HorizontalPlayerOne");

        transform.Translate(new Vector3(horizontalInput1,0f,0f)*m_Speed*Time.deltaTime);

        _Anim.SetFloat("PlayerHorizontal", horizontalInput1);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Obstacle")
        {

            GameManager.health -= 1;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class RoadMovement : MonoBehaviour
{
    public float roadSpeed = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0f,0f,-roadSpeed) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other){
        
        if(other.gameObject.CompareTag("Destroy")){
            Destroy(gameObject);
        }
    }
}

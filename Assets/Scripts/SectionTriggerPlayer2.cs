using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionTriggerPlayer2 : MonoBehaviour
{
    public List<GameObject> roadSection;
    
    private float zPos = 424f;
    private float xPos = 0f;
    public int secNum;

    public static int counterRoad2 = 0;

    
   
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            secNum = Random.Range(0,5);
            Instantiate(roadSection[secNum], new Vector3(xPos,0f,zPos), Quaternion.identity);
           
        }

        
        if(other.gameObject.CompareTag("Trigger")){

            counterRoad2 += 1;
            Debug.Log("Contador" + counterRoad2); 
        }
    }

    
}

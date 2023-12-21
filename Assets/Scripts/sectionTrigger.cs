using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sectionTrigger : MonoBehaviour
{
    public GameObject roadSection;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(roadSection, new Vector3(0, 0, 180), Quaternion.identity);
        }
    }
}

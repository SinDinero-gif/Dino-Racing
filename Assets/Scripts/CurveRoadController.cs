using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveRoadController : MonoBehaviour
{
    public Material CurveMat;
    public float RoadDistance = 0;
    public float RoadCurve = 0;
    

    void Start(){
        CurveMat.GetFloat("_Sideways_Strength");
    }

    void Update(){
        RoadDistance+= 5 * Time.deltaTime;
        

        if (RoadDistance >= 1000){

            CurveMat.SetFloat("_Sideways_Strength", RoadCurve += 0.0001f);
        }

        if(RoadCurve == 0.001f){
            RoadCurve = 0.001f;
            CurveMat.SetFloat("_Sideways_Strength", 0.001f);
        }

    }

}

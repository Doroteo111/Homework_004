using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_3 : MonoBehaviour
{
   
    public float upperLimit = 1f;
    public float lowerLimit = 10f;
    private float result;

    private void Start()
    {
               
        RandomVector(upperLimit, lowerLimit);
        Debug.Log($"Random vector : {result}");
    }
    private float RandomVector(float x, float y)
    {
       
        result = Random.Range(x, y); //to generate random number
        return result;
    }
}

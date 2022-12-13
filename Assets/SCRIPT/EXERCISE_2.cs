using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_2 : MonoBehaviour
{
    
    public float centimetres = 10f;
    private float result;

    private void Start()
    {
        Convert(centimetres);   
        Debug.Log($"This centimietres are {result} inches");
    }
    private float Convert(float x)
    {
        result= x * 0.393701f;  //calculation to convert cm to inch
        return result;
    }
}

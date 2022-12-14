using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_5 : MonoBehaviour
{
    
    public float Xlimit = 10;
    public float Ylimit = 2;
    public float Zlimit = 10;
    private void Start()
    {
      if(IsOutOfBounds(Xlimit, Ylimit, Zlimit)==true)
        {
            Debug.Log("Is inside bounds");
        }
    }

    private bool IsOutOfBounds(float LimX, float LimY, float LimZ) //POSITION
    {
       

        if (transform.position.x > LimX || transform.position.x < -LimX)
        {
            return true;
        }

        if(transform.position.z > LimY || transform.position.z < -LimY)
        {
            return true;
        }
        if (transform.position.z > LimZ || transform.position.z < -LimZ)
        {
            return true;
        }

        return false;
    }
}

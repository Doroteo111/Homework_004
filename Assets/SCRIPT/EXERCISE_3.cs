using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_3 : MonoBehaviour
{
    // Create a function that, given a lower and an upper limit, generates a random vector within those limits.For this
    // function you will need:• Two inputs • An output

    public float upperLimit = 10f;
    public float lowerLimit = 1f;

    private void Start()
    {
        AreaLimit();
    }

    private Vector3 AreaLimit()
    {
       float randomX = Random.Range(-upperLimit, upperLimit);
        return new Vector3(randomX, lowerLimit, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    // Create a function that acts as a money box. We can put money in and the total is increased.For this function
    // you will need:
    //• An input
    //Outside of the function you will need a variable that stores the total amount. This total is the
    //one that is modified by the function.

    public int money = 10;
    private int totalMoney;

    private void Start()
    {
        SumMoney(money);
        Debug.Log($"You have in total,{totalMoney} money");
    }
    private void SumMoney(int x)
    {
        totalMoney = x + totalMoney;
       
    }
}

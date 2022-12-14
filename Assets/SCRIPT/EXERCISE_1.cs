using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    public int money = 10;
    private int totalMoney;

    private void Start()
     {
         SumMoney();
         Debug.Log($"You have in total,{totalMoney} money");
        
     }
    
    private void SumMoney()
    {
        totalMoney = money + totalMoney;
       
    }
}

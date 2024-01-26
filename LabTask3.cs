using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabTask3 : MonoBehaviour
{
    //Public variable where amount of money can be inputted.
    public int moneyEarned;
    void Start()
    {
        CalculateBills();
    }

    //Function that calculates how much of each bill we have depending on the amount of money inputted in the inspector.
    void CalculateBills()
    {
        //Create an array with our various bill denominations.
        int[] billDenominations = { 100, 50, 20, 10, 5, 1 };
 
        //Display the money earned in the console so it is easy to see the distribution of the money into the different bills.
        Debug.Log($"Bills for ${moneyEarned}");

        //For each of the numbers in the int array, denomination will be what refers to it and the following operations will occur.
        foreach (var denomination in billDenominations)
        {
            //To figure out the number of bills, take the money and divide it by the denomination beginning at 100.
            int numberOfBills = moneyEarned / denomination;
            //Debug.Log($"/{moneyEarned} and {denomination} and {numberOfBills}");
            //Take the money and divide it by the denomination. Then, make the money the remainder.
            //For example, 182 goes into 100 one time with 82 left over. This makes the new amount of money 82 and then the math will occur again with the next denomination.
            moneyEarned %= denomination;
            //Debug.Log($"%{moneyEarned} and {denomination}");

            //If our number of bills is above 0, display how many bills of that denomination. No point in displaying 0 bills, so only display if there is at least 1.
            if (numberOfBills > 0)
            {
                Debug.Log($"{numberOfBills} x ${denomination} bill(s)");
            }
        }
    }
}
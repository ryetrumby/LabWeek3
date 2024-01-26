using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabTask1 : MonoBehaviour
{
    float chalScore; //Challenge Score
    public string courseName; //Course name
    public float moduleNum; //# of modules
    public float readMat; //# of reading materials
    public float quiz; //# of quizzes
    public float assign; //# of assignments
    public float instructor; //instructor experience
    float addedTogether; //All percentages added together.

    //Assumption - There can only be 1 module, reading material, quiz, and assignment in one week
   
    
    
    
   
    void Start()
    {
        ConvertPercentages();
        DisplayValues();
    }
   
    void ConvertPercentages()
    {
        //Add all the percentages together.
        addedTogether = moduleNum + readMat + quiz + assign + instructor;
        //Debug.Log(addedTogether);

        //Divide the percentages by 10 to get a chal score that is between 1 and 10.
        chalScore = addedTogether/10;
        //Debug.Log(chalScore);
    }

    void DisplayValues()
    {
        Debug.Log($"The course is {courseName} and it has a challenge score of {chalScore}");
    }
}
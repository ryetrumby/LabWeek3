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

    //Assumption - There can only be 1 module, reading material, quiz, and assignment in one week
    //Assumption - Input for instructor is a 0 or 1, with 0 being experience and 1 being no experience
   
    
    
    
   
    void Start()
    {
        ConvertPercentages();
        DisplayValues();
    }
   
    void ConvertPercentages()
    {
        //Create correct values for the scale
        moduleNum = moduleNum / 10;
        readMat = (readMat / 10) * 2;
        quiz = quiz / 10;
        assign = (assign / 10) * 2;
        
        //Add all the percentages together.
        chalScore = moduleNum + readMat + quiz + assign + instructor;
        //Debug.Log(chalScore);

      
    }

    void DisplayValues()
    {
        Debug.Log($"The course is {courseName} and it has a challenge score of {chalScore}");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabAssignment1 : MonoBehaviour
{
    public float chalScore; //Challenge Score
    public string courseName; //Course name
    public float moduleNum; //# of modules
    public float readMat; //# of reading materials
    public float quiz; //# of quizzes
    public float assign; //# of assignments
    public float instructor; //instructor experience

    //Assumption - There can only be 1 module, reading material, quiz, and assignment in one week
   
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ConvertPercentages();
        DisplayValues();
    }

    void UserInput()
    {
        
    }

    void ConvertPercentages()
    {
        moduleNum /= 10;
        readMat /= 10;
        quiz /= 10;
        assign /= 10;
        instructor /= 10;

        chalScore = moduleNum + readMat + quiz + assign + instructor;
    }

    void DisplayValues()
    {
        Debug.LogFormat("The course is {0} and has a challenge score of: {1}", courseName, chalScore);
    }
}

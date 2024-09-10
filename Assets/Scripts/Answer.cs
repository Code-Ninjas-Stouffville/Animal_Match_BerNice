using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool correctAnswer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReviewAnswer()
    {
        if(correctAnswer == true) 
        {
            Debug.Log("correct");
            transform.parent.GetComponent<QuestionGenerate>().answeredQuestions += 1;
        }
        else
        {
            Debug.Log("wrong answer");
        }
    }
}

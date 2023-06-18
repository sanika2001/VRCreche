using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ShapeGameLevel2 : MonoBehaviour
{
   
    public TMP_Text question;
    public TMP_Text answer;
    
    //public TMP_Text score;
    
    string shape;

    void displayQuestion() {
        var My_dict1  = new Dictionary<int, string>()
                       {
                           { 1,"Identify the sphere"},
                           { 2,"Identify the cylinder"},
                           { 3,"Identify the cube"},
                           {4,"Identify the capsule" },
                       };

        int randomNumber = Random.Range(1, 5);
        question.text = My_dict1[randomNumber];

    }


    void Start()
    {
        displayQuestion();
    }

     void OnMouseDown()
     {
       
       ShapeCheck();
        
     }

     void ShapeCheck()
     {
        shape = question.text.Substring(question.text.LastIndexOf(' ') + 1);

       if(shape==gameObject.tag)
       {
        answer.text ="You got it right!";
        answer.color = new Color32(0, 255, 0, 255);

        BeginGame.score+=10;
        Invoke("reset",1);

       }
       else
       {
        answer.text = "Sorry, wrong answer";
        BeginGame.score -= 2;
        answer.color = new Color32(255, 0,0 ,255);

        Invoke("reset",1);
       }

       if(BeginGame.shapeLevel2Q!=0)
       {
        displayQuestion();
        //ShapeCheck();
        BeginGame.shapeLevel2Q--;
       }

        if(BeginGame.shapeLevel2Q==0)
       {
        SceneManager.LoadSceneAsync("ResultScreen");
       }
     }
     void reset()
     {
        answer.text = "";
     }
   
}
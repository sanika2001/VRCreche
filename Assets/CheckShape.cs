using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckShape : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text question;
    public TMP_Text answer;
    public TMP_Text score;
    
    int questions = 7;
    string shape;

    void displayQuestion() {
        var My_dict1  = new Dictionary<int, string>()
                       {
                           { 1,"Find the rectangle"},
                           { 2,"Find the triangle"},
                           { 3,"Find the circle"},
                           {4,"Find the arc" },
                           {5,"Find the heart" },
                           { 6,"Find the pentagon"},
                           {7,"Find the donut"},
                           {8,"Find the pie"}
                       };

        int randomNumber = Random.Range(1, 9);
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

        BeginGame.score+=5;
        
        score.text = (int.Parse(score.text)*-1).ToString();

       }
       else
       {
        answer.text = "Sorry, wrong answer";
        BeginGame.score -= 1;
        answer.color = new Color32(255, 0,0 ,255);
       }

       if(questions!=0)
       {
        displayQuestion();
        //ShapeCheck();
        questions--;
       }
     }
   
}
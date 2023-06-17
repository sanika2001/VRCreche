using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckShape : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text question;
    public TMP_Text answer;
    public TMP_Text score;
    
    
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
       if(BeginGame.shapeLevel1Q!=0)
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

       if(BeginGame.shapeLevel1Q!=0)
       {
        displayQuestion();
        //ShapeCheck();
        BeginGame.shapeLevel1Q--;
       }
       if(BeginGame.shapeLevel1Q==0 && BeginGame.score>20)
       {
        SceneManager.LoadSceneAsync("ShapeLev2");
       }
       else if(BeginGame.shapeLevel1Q==0)
       {
        BeginGame.shapeLevel1Q = 6;
        BeginGame.score = 0;
        SceneManager.LoadSceneAsync("shapeGame");
       }
     }
   
}
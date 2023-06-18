using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Resultcode : MonoBehaviour
{

    public TextMeshProUGUI scoreVal;
    public TextMeshProUGUI comment;
    public TextMeshProUGUI feedback;
    void Start()
    {
        scoreVal.text = "" + BeginGame.score;

        if (BeginGame.score >= 90) {
            comment.text = "Excellent";
            feedback.text = "You are brilliant! Keep on the good work";
        }else if (BeginGame.score >= 75)
        {
            comment.text = "Very Good";
            feedback.text = "You are awsome! Practice more and be excellent";
        }
        else if (BeginGame.score >= 60)
        {
            comment.text = "Good";
            feedback.text = "You are really good! Practice more and be excellent";
        }
        else if (BeginGame.score >= 40)
        {
            comment.text = "Practice more";
            feedback.text = "You've got this! Practice more and be excellent";
        }
        else
        {
            comment.text = "Learn again";
            feedback.text = "You've got this! Practice more and be excellent";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

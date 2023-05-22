using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ShapeScript : MonoBehaviour
{
    public TMP_Text question;
    // Start is called before the first frame update
    

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

    // Update is called once per frame
    
}

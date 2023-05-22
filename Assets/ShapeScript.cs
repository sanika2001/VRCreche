using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ShapeScript : MonoBehaviour
{
    public TextMeshProUGUI question;
    // Start is called before the first frame update
    Dictionary<string, string> My_dict1 =
                       new Dictionary<string, string>()
                       {
                           { "Find the square", "Welcome"},
                           { "Find the triangle", "to"},
                           { "Find the circle", "GeeksforGeeks"},
                           {"Find the arc", "Welcome" },
                           {"Find the heart", "to" },
                           { "Find the pentagon", "GeeksforGeeks"}
                       };

    public void displayQuestion() {
        //public int randomNumber = Random.Range(0, 6);

    }


    void Start()
    {
        displayQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

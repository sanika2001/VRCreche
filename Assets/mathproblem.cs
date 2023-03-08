using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class mathproblem : MonoBehaviour
{
    public Material wallMaterial;
    public TextMeshProUGUI firstnumber;
    public TextMeshProUGUI secondnumber;
    public TextMeshProUGUI answer1;
    public TextMeshProUGUI answer2;
    public TextMeshProUGUI answer3;

    public List<int> easyMathList = new List<int>();

    public int randomFirstNumber;
    public int randomSecondNumber;
    int firstNumberInProblem;
    int secondNumberInProblem;
    int answerOne;
    int answerTwo;
    int answerThree;
    int displayRandomAnswer;
    int randomAnswerPlacement;
    
    public int currentAnswer;
    public TextMeshProUGUI rightOrWrong_Text;
     
    public void DisplayMathProblem() {
        //generate a random numb as 1st and 2nd numb
        randomFirstNumber = Random.Range(0,easyMathList.Count + 1);
        randomSecondNumber = Random.Range(0,easyMathList.Count + 1);
        //assign your first and second numb
        firstNumberInProblem = randomFirstNumber;
        secondNumberInProblem = randomSecondNumber;
        //can use addition/sub/mult/div
        answerOne = firstNumberInProblem + secondNumberInProblem;
        displayRandomAnswer = Random.Range(0,3);
        if (displayRandomAnswer == 0)
        {
            answerTwo = answerOne + Random.Range(1, 10);
            answerThree = answerOne - Random.Range(1, 5);
        }
        else if (displayRandomAnswer == 1)
        {
            answerTwo = answerOne - Random.Range(1, 5);
            answerThree = answerOne + Random.Range(1, 5);
        }
        else {
            answerTwo = answerOne - Random.Range(1, 5);
            answerThree = answerOne + Random.Range(1, 10);
        }

        firstnumber.text = ""+firstNumberInProblem;
        secondnumber.text = ""+secondNumberInProblem;
        randomAnswerPlacement = Random.Range(0,3);
        if (randomAnswerPlacement == 0)
        {
            answer1.text = "" + answerOne;
            answer2.text = "" + answerTwo;
            answer3.text = "" + answerThree;
            currentAnswer = 0;
        }
        else if (randomAnswerPlacement == 0)
        {
            answer1.text = "" + answerThree;
            answer2.text = "" + answerOne;
            answer3.text = "" + answerTwo;
            currentAnswer = 1;
        }
        else {
            answer1.text = "" + answerTwo;
            answer2.text = "" + answerThree;
            answer3.text = "" + answerOne;
            currentAnswer = 2;
        }       
    }

    public void ButtonAnswer1(){
        if(currentAnswer == 0){

            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Correct");
            Invoke("TurnOffText",1);
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            wallMaterial.color = newColor;
        }
        else{
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("Try Again!");
            Invoke("TurnOffText",1);
        }
    }
    public void ButtonAnswer2(){
        if(currentAnswer == 1){

            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Correct");
            Invoke("TurnOffText",1);
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            wallMaterial.color = newColor;
        }
        else{
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("Try Again!");
            Invoke("TurnOffText",1);
        }
    }
    public void ButtonAnswer3()
    {
        if (currentAnswer == 2)
        {

            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Correct");
            Invoke("TurnOffText", 1);
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            wallMaterial.color = newColor;
        }
        else
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("Try Again!");
            Invoke("TurnOffText", 1);
        }
    }
    public void TurnOffText(){

        if(rightOrWrong_Text != null)
            rightOrWrong_Text.enabled = false;
        DisplayMathProblem();
    }


    // Start is called before the first frame update
    void Start()
    {
        DisplayMathProblem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class mathproblem : MonoBehaviour
{
    public Material wallMaterial;
    public Material floorMaterial;
    public TextMeshProUGUI firstnumber;
    public TextMeshProUGUI secondnumber;
    public TextMeshProUGUI thirdnumber;
    public TextMeshProUGUI answer1;
    public TextMeshProUGUI answer2;
    public TextMeshProUGUI answer3;
    public TextMeshProUGUI ScoreVal;
    public TextMeshProUGUI LevelVal;
    public TextMeshProUGUI plus;

    public List<int> easyMathList = new List<int>();

    public int randomFirstNumber;
    public int randomSecondNumber;
    public int randomThirdNumber;
    public int noofQuestions = 0;
    int firstNumberInProblem;
    int secondNumberInProblem;
    int thirdNumberInProblem;
    int answerOne;
    int answerTwo;
    int answerThree;
    int displayRandomAnswer;
    int randomAnswerPlacement;
    int currentScore = 0;
    int level = 1;
    int levelWeight = 5;
    int levelsubWeight = 1;
    
    public int currentAnswer;
    public TextMeshProUGUI rightOrWrong_Text;

    //var Arraylist = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Purple, Color.Black, Color.Aqua };
    //List<Color[]> color = new List<Color[]>();
    //color.Add(Arraylist);
     
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
            currentScore += levelWeight;
            ScoreVal.text = "" + currentScore;
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Yay! You got it");
            if (currentScore >= 25 && noofQuestions <= 7 && level == 1)
            {
                level = 2;
                LevelVal.text = "" + level;
            }
            Invoke("TurnOffText",1);
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            wallMaterial.color = newColor;
            newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            floorMaterial.color = newColor;
            
        }
        else{
            currentScore -= levelsubWeight;
            ScoreVal.text = "" + currentScore;
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("incorrect,Try again!");
            Invoke("TurnOffText",1);
        }
    }
    public void ButtonAnswer2(){
        if(currentAnswer == 1){
            currentScore += levelWeight;
            ScoreVal.text = "" + currentScore;
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Yay! You got it");
            if (currentScore >= 25 && noofQuestions <= 7 && level == 1)
            {
                level = 2;
                LevelVal.text = "" + level;
            }else
            Invoke("TurnOffText",1);
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            wallMaterial.color = newColor;
            newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            floorMaterial.color = newColor;
        }
        else{
            currentScore -= levelsubWeight;
            ScoreVal.text = "" + currentScore;
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("incorrect,Try again!");
            Invoke("TurnOffText",1);
        }
    }
    public void ButtonAnswer3()
    {
        if (currentAnswer == 2)
        {
            currentScore += levelWeight;
            ScoreVal.text = "" + currentScore;
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Yay! You got it");
            if (currentScore >= 25 && noofQuestions <= 7 && level == 1)
            {
                level = 2;
                LevelVal.text = "" + level;
            }
            Invoke("TurnOffText", 1);
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            wallMaterial.color = newColor;
            newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            floorMaterial.color = newColor;
        }
        else
        {
            currentScore -= levelsubWeight;
            ScoreVal.text = "" + currentScore;
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("incorrect,Try again!");
            Invoke("TurnOffText", 1);
        }
    }


    public void DisplayMathProblemLev2()
    {
        //generate a random numb as 1st and 2nd numb
        randomFirstNumber = Random.Range(0, easyMathList.Count + 1);
        randomSecondNumber = Random.Range(0, easyMathList.Count + 1);
        randomThirdNumber = Random.Range(0, easyMathList.Count + 1);
        //assign your first and second numb
        firstNumberInProblem = randomFirstNumber;
        secondNumberInProblem = randomSecondNumber;
        thirdNumberInProblem = randomThirdNumber;
        //can use addition/sub/mult/div
        answerOne = firstNumberInProblem + secondNumberInProblem + thirdNumberInProblem;
        displayRandomAnswer = Random.Range(0, 3);
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
        else
        {
            answerTwo = answerOne - Random.Range(1, 5);
            answerThree = answerOne + Random.Range(1, 10);
        }

        firstnumber.text = "" + firstNumberInProblem;
        secondnumber.text = "" + secondNumberInProblem;
        thirdnumber.text = "" + thirdNumberInProblem;
        plus.text = "+";
        randomAnswerPlacement = Random.Range(0, 3);
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
        else
        {
            answer1.text = "" + answerTwo;
            answer2.text = "" + answerThree;
            answer3.text = "" + answerOne;
            currentAnswer = 2;
        }
    }




    public void TurnOffText(){

        if(rightOrWrong_Text != null)
            rightOrWrong_Text.enabled = false;
        if (level == 1)
        {
            noofQuestions += 1;
            DisplayMathProblem();
        }
        else
        {
            levelWeight = 10;
            levelsubWeight = 2;
            DisplayMathProblemLev2();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        noofQuestions += 1;
            DisplayMathProblem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

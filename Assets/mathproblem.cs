using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class mathproblem : MonoBehaviour
{

    public TextMeshProUGUI firstnumber;
    public TextMeshProUGUI secondnumber;
    public TextMeshProUGUI answer1;
    public TextMeshProUGUI answer2;

    public List<int> easyMathList = new List<int>();

    public int randomFirstNumber;
    public int randomSecondtNumber;
    int firstNumberInProblem;
    int secondNumberInProblem;
    int answerOne;
    int answerTwo;
    int displayRandomAnswer;
    int randomAnswerPlacement;
    
    public int currentAnswer;
    public TextMeshProUGUI rightOrWrong_Text;
     
    public void DisplayMathProblem() {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreIncrease : MonoBehaviour
{

    public TMP_Text check;
    public TMP_Text score;
    int points = 0;
    // Start is called before the first frame update
    int x = -1;

    // Update is called once per frame
    void Update()
    {
        if(x==int.Parse(check.text))
        {
            points+=5;
            score.text = points.ToString();
            x*=-1;
        }

    }
}

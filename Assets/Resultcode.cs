using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Resultcode : MonoBehaviour
{

    public TextMeshProUGUI scoreVal;
    void Start()
    {
        scoreVal.text = "" + BeginGame.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

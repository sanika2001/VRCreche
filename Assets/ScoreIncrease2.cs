using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreIncrease2 : MonoBehaviour
{

    public TMP_Text score;
    public Material wallMaterial;
    public Material floorMaterial;


    // Update is called once per frame
    void Update()
    {
         wallMaterial.color = new Color32(68, 51, 150,255);
         floorMaterial.color = new Color32(148, 105, 141,255);
         score.text = BeginGame.score.ToString();

    }
}


 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreIncrease : MonoBehaviour
{

    public TMP_Text score;
    public Material wallMaterial;
    public Material floorMaterial;


    // Update is called once per frame
    void Update()
    {
         wallMaterial.color = new Color32(7, 107, 105,255);
         floorMaterial.color = new Color32(148, 105, 141,255);
         score.text = BeginGame.score.ToString();

    }
}

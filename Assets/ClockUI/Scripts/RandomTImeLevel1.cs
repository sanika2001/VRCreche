using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomTImeLevel1 : MonoBehaviour
{
   
    public TMP_Text time;
    public Material wallMaterial;
    public Material floorMaterial;
    public RawImage levelupImg;
    public int m,h;

    void Start()
    {
        levelupImg.enabled = false;
        wallMaterial.color = new Color32(68, 51, 150,255);
        floorMaterial.color = new Color32(148, 105, 141,255);
        string s = RandomHour() +":"+ "00";
        
        time.text = s;
    }

    string RandomHour()
    {
        h = Random.Range(1, 13);
        if(h==12)
            h=1;
        

        string hour = h.ToString();

        if(h<10)
        {
            hour = "0"+hour;
        }
        return hour;
    }
    
     

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomTime : MonoBehaviour
{
   
    public TMP_Text time;

    void Start()
    {
        string s = RandomHour() +":"+ RandomMinute();
        
        time.text = s;
    }

    string RandomHour()
    {
        int h = Random.Range(1, 13);
        Debug.Log(h);

        string hour = h.ToString();

        if(h<10)
        {
            hour = "0"+hour;
        }
        return hour;
    }
    
    string RandomMinute()
    {
        int m = Random.Range(0,12)*5;

        string minute = m.ToString();

        if(m<10)
        {
            minute = "0"+minute;
        }

        return minute;
    }
     

}

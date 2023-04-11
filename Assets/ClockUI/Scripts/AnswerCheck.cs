using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public MinuteChange M;
    public HourChange H;
    public TMP_Text time;
    public TMP_Text answer;



    public void checkAnswer()
    {
        int mClick = M.mClicks;
        int hClick = H.hClicks;

        string t = time.text;

        string h="";
        string m="";

        int i;

        for(i=0;i<t.Length;i++)
        {
            if(t[i]==':')
                break;
            h+=t[i];
        }

        
        i++;
        for(;i<t.Length;i++)
        {
            m+=t[i];
        }
        
        int hour,minute;

        Debug.Log(h+m);

        // if(h[0]=='0')
        //     hour = h[1]-'0';
        // else
            hour = int.Parse(h);

        // if(m[0]=='0'&&m[1]=='0')
        //     minute = 0;
        // else if(m[0]=='0')
        //     minute = m[1]-'0';
        // else
            minute = int.Parse(m);
        

        int trueH =0,trueM=0;

        if(hour==12 && hClick==0)
            trueH = 1;

        if(hour==hClick)
            trueH = 1;
        
        if(minute==mClick*5)
            trueM = 1;

        if(trueH==1&&trueM==1)
            answer.text = "Correct!";
        else
            answer.text = "Wrong!";
       
    }
}

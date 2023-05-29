using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerCheck : MonoBehaviour
{
    
    //public static int points = 0;
    public MinuteChange M;
    public HourChange H;
    public TMP_Text time;
    public TMP_Text answer;
    public TMP_Text score;
    
    
    //to reset the hands
    private float SceneWidth;
    private Vector3 PressP;
    private Quaternion StartRotation;
    [SerializeField] private Transform minuteHand, hourHand;

    int questions = 7;



    public void Start()
    {
        score.text = "Score : "+BeginGame.score.ToString();
    }
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
        {
            answer.text = "Correct!";
            answer.color = new Color32(0, 255, 0, 255);
            BeginGame.score+=10;
            score.text = "Score : "+BeginGame.score.ToString();
        }
        else
        {
            answer.text = "Wrong!";
            answer.color = new Color32(255, 0,0 ,255);
            BeginGame.score-=2;
            score.text = "Score : "+BeginGame.score.ToString();
        }


        if(questions>1)
        {
                time.text = RandomTime();
                questions--;
        }
            
       
    }

    string RandomTime()
    {
        string s = RandomHour() +":"+ RandomMinute();

        hourHand.Rotate(Vector3.forward, H.hClicks*30); //resetting position of hour dial 

        minuteHand.Rotate(Vector3.forward, M.mClicks*30); //resetting minute hands
        hourHand.Rotate(Vector3.forward, M.mClicks*2.5f);

        M.mClicks=0;  //making number of minute clicks on the clock zero

        H.hClicks =0; //making number of hour clicks on the clock zero
        
        return s;
    }

    

    string RandomHour()
    {
        int h = Random.Range(1, 13);
        

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
         if(m==0)
            m=5;

        string minute = m.ToString();

        if(m<10)
        {
            minute = "0"+minute;
        }
        

        return minute;
    }
}

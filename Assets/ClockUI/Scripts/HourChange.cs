using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourChange : MonoBehaviour
{

    [SerializeField] private Transform  hourHand;

    public int hClicks = 0;

   
    public void changeHour()
	{
		
		// select the axis by which you want to rotate the GameObject


		hClicks++;
		// transform.Rotate(Vector3.forward, -1*Mathf.Abs(XaxisRotation));
        // transform.Rotate(Vector3.forward, -1*Mathf.Abs(YaxisRotation));
       // minuteHand.Rotate(Vector3.forward, -30);
        hourHand.Rotate(Vector3.forward, -30);
        
	}
}

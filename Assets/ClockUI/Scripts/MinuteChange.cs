using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MinuteChange : MonoBehaviour
{
 
    private float SceneWidth;
    private Vector3 PressP;
    private Quaternion StartRotation;

    public int mClicks = 0;

    [SerializeField] private Transform minuteHand, hourHand;
    // Start is called before the first frame update
    
    // Update is called once per frame
    // void OnMouseOver()
    // {

        
    //     if(Input.GetMouseButtonDown(0))
    //     {
    //         PressP = Input.mousePosition;
    //         StartRotation = transform.rotation;
    //         Debug.Log(PressP);
            
    //     }
    //     else if(Input.GetMouseButton(0))
    //     {
    //         float CurrentD = (Input.mousePosition - PressP).x;
    //         Debug.Log(CurrentD);
    //         transform.rotation = StartRotation*Quaternion.Euler( Vector3.forward*(CurrentD/SceneWidth)*360);
    //     }
    // }
    public void minuteChange()
	{
		float XaxisRotation = Input.GetAxis("Mouse X")*10;
		float YaxisRotation = Input.GetAxis("Mouse Y")*10;

        mClicks++;


		// select the axis by which you want to rotate the GameObject


		
		// transform.Rotate(Vector3.forward, -1*Mathf.Abs(XaxisRotation));
        // transform.Rotate(Vector3.forward, -1*Mathf.Abs(YaxisRotation));
        minuteHand.Rotate(Vector3.forward, -30);
        hourHand.Rotate(Vector3.forward, -2.5f);
        
	}
    public void reset()
    {
        minuteHand.Rotate(Vector3.forward, mClicks*30);
        hourHand.Rotate(Vector3.forward, mClicks*2.5f);
        mClicks=0;

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float SceneWidth;
    private Vector3 PressP;
    private Quaternion StartRotation;

    [SerializeField] private Transform minuteHand, hourHand;
    // Start is called before the first frame update
    void Start()
    {
        SceneWidth = Screen.width;
    }

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
    void OnMouseDown()
	{
		float XaxisRotation = Input.GetAxis("Mouse X")*10;
		float YaxisRotation = Input.GetAxis("Mouse Y")*10;
		// select the axis by which you want to rotate the GameObject


		
		// transform.Rotate(Vector3.forward, -1*Mathf.Abs(XaxisRotation));
        // transform.Rotate(Vector3.forward, -1*Mathf.Abs(YaxisRotation));
        minuteHand.Rotate(Vector3.forward, -30);
        hourHand.Rotate(Vector3.forward, -2.5f);
        
	}

}

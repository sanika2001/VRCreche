using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscope : MonoBehaviour
{
    // Start is called before the first frame update
    int phone = 0;
   
   void Start ()
     {
        Debug.Log(SystemInfo.deviceType);
        if(SystemInfo.deviceType == DeviceType.Handheld)
        {
           
            Input.gyro.enabled = true;
            phone=1;
        }
        
     }

  void Update ()
     {
        
        if(phone==1)
        {
          GyroModifyCamera();
        }
     }
      void GyroModifyCamera()
    {
        transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}

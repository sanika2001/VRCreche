using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscope : MonoBehaviour
{
    // Start is called before the first frame update
    int phone = 0;
   
   void Start ()
     {
        
           
            Input.gyro.enabled = true;
            phone=1;
        
        
     }

  void Update ()
     {
             
        
          GyroModifyCamera();
        
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

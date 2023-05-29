

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroNew : MonoBehaviour
{
//  private bool gyroEnabled;
//  private Gyroscope gyro;

//  private GameObject cameraContainer;
//  private Quaternion rot;

//  private void Start()
//  {
//   cameraContainer = new GameObject ("Camera Container");
//   cameraContainer.transform.position = transform.position;
//   transform.SetParent (cameraContainer.transform);

//   gyroEnabled = EnableGyro ();
//  }

//  private bool EnableGyro()
//  {
//   if (SystemInfo.supportsGyroscope) 
//   {
//    gyro = Input.gyro;
//    gyro.enabled = true;

//    cameraContainer.transform.rotation = Quaternion.Euler (90f, 90f, 0f);
//    rot = new Quaternion (1, 0, 0, 0);

//    return true;
//   }
//   return false;
//  }
//  private void Update()
//  {
//   if (gyroEnabled)
//   {
//    transform.localRotation = gyro.attitude * rot;
//   }
//  }
// }
  void Start () 
     {
         Input.gyro.enabled = true;
     }
 
     void Update () 
     {
         //var x = Input.gyro.rotationRateUnbiased.x;
         //transform.eulerAngles = new Vector3 (x, 0, 0);
         transform.Rotate (0, -Input.gyro.rotationRateUnbiased.y, 0);
     }
 }
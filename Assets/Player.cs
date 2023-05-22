using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Player : MonoBehaviour
{
    [SerializeField]private float speed;
    

    
    
    
    
    private void Update(){
        float xMovement=SimpleInput.GetAxis("Horizontal");
         float zMovement=SimpleInput.GetAxis("Vertical");
        
        transform.position+=new Vector3(xMovement,0f,zMovement)*speed*Time.deltaTime;
         

        
    
         
    }
}
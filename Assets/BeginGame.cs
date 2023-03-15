using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Varsha1");
    }
    
    public void Back()
    {
        SceneManager.LoadSceneAsync("Varsha");
    }
    
    public void BasicArith()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }
}

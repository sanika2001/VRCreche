using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    public void Arith_Play()
    {
        SceneManager.LoadSceneAsync("ArithPlay");
    }
    
    public void Arith_Back()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    
    public void Arith_Game()
    {
        SceneManager.LoadSceneAsync("jyothir");
    }
}

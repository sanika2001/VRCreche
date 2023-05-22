using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void Arith_Play()
    {
        SceneManager.LoadSceneAsync("ArithPlay");
    }
    
    public void Alpha_Game()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void Alpha_Play()
    {
        SceneManager.LoadSceneAsync("AlphaPlay");
    }
    
    public void Arith_Game()
    {
        SceneManager.LoadSceneAsync("jyothir");
    }

    public void Time_Play()
    {
        SceneManager.LoadSceneAsync("TimePlay");
    }
   
    public void Time_Game()
    {
        SceneManager.LoadSceneAsync("ClockLev1");
    }

    public void Quit_App()
    {
        Application.Quit();
    }
}

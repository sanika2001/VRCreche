using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    public static int score = 0;
    public void MainMenu()
    {
        score = 0;
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void Arith_Play()
    {
        score = 0;
        SceneManager.LoadSceneAsync("ArithPlay");
    }
    
    public void Shape_Game()
    {
        score = 0;
        SceneManager.LoadSceneAsync("shapeGame");
    }

    public void Shape_Play()
    {
        score = 0;
        SceneManager.LoadSceneAsync("ShapePlay");
    }
    
    public void Arith_Game()
    {
        score = 0;
        SceneManager.LoadSceneAsync("jyothir");
    }

    public void Time_Play()
    {
        score = 0;
        SceneManager.LoadSceneAsync("TimePlay");
    }
   
    public void Time_Game()
    {
        score = 0;
        SceneManager.LoadSceneAsync("ClockLev1");
    }

    public void ResultScreen()
    {
        SceneManager.LoadSceneAsync("ResultScreen");
    }

    public void Quit_App()
    {
        score = 0;
        Application.Quit();
    }
}

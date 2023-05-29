using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    public static int score = 0;
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void Arith_Play()
    {
        SceneManager.LoadSceneAsync("ArithPlay");
    }
    
    public void Shape_Game()
    {
        SceneManager.LoadSceneAsync("shapeGame");
    }

    public void Shape_Play()
    {
        SceneManager.LoadSceneAsync("ShapePlay");
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

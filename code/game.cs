using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class game : MonoBehaviour
{
    public void Exitgame()
    {
        Application.Quit();
    }

    public void Startgame()
    {
        SceneManager.LoadScene(0);
    }
}

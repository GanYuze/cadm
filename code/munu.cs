using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class munu : MonoBehaviour
{
    
    public void Start1()
    {
      GameObject.Find("相机控制").GetComponent<xingji>().right();
    }

    public void Back()
    {
        GameObject.Find("相机控制").GetComponent<xingji>().left();
    }

    public void Exitgame()
    {
        Application.Quit();
    }

    public void Startgame()
    {
        SceneManager.LoadScene(1);
    }
}

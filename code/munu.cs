using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class munu : MonoBehaviour
{
    
    public void Start1()
    {
      GameObject.Find("�������").GetComponent<xingji>().right();
    }

    public void Back()
    {
        GameObject.Find("�������").GetComponent<xingji>().left();
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

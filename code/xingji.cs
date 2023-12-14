using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xingji : MonoBehaviour
{
    public void right()
    {
      transform.Translate(2000, 0, 0);
    }

    public void left()
    {
       transform.Translate(-2000, 0, 0);
    }

}

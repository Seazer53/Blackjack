using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
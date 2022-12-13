using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Startbutton()
    {
        SceneManager.LoadScene(1);
    }
    
    public void quitButton()
    {
        Application.Quit();
    }
}

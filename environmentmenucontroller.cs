using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class environmentmenucontroller : MonoBehaviour
{
    public void ForestButton()
    {
        SceneManager.LoadScene(3);
    }
    
    public void BeachButton()
    {
        SceneManager.LoadScene(4);
    }
    
    public void SpaceButton()
    {
        SceneManager.LoadScene(5);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    
}


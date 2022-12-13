using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class example_timer : MonoBehaviour
{
    float countdown = 60;
    float tolerance = 0.00001F;
    public TMP_Text tex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if(countdown < tolerance)
        {
            SceneManager.LoadScene(0);
        }
        
        if(countdown>0)
        {
            countdown-=Time.deltaTime;
        }
        double b=System.Math.Round(countdown,2);
        tex.text=b.ToString();
        
    }
}

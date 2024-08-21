using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
   public GameObject panel;
    //for button pause
    if (Input.GetKeyDown(KeyCode.//YoureKey))
    {
      pausegame();
    }
    
    public void pausegame()
    { 
        Time.timeScale = 0f;
        panel.SetActive(true);       
    }
    //To exit menu/pause
     public void playtogame()
    { 
        Time.timeScale = 1f;
        panel.SetActive(false);       
    }
}

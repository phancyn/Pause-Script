using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pause : MonoBehaviour
{
    public GameObject panel;
    public void pausegame()
    { 
        Time.timeScale = 0f;
        panel.SetActive(true);       
    }



    public void continuegame()
    { 
        Time.timeScale = 1f;
        panel.SetActive(false);       
    }
}

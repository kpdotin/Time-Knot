using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject MenuPanel;
    
    public void Play()
    {
        SceneManager.LoadScene(14);
    }
    public void Quit()
    {
        Application.Quit();
    }
   
}

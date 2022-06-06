using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    public void ReturnMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");
    }
    
}

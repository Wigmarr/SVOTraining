using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void LoadTeachingScene()
    {
        SceneManager.LoadScene("TeachingScene");
    }

    public void LoadTestingScene()
    {
        SceneManager.LoadScene("TestingScene");
    }

    public void LoadPracticeScene()
    {
        SceneManager.LoadScene("PracticeScene");
    }
}

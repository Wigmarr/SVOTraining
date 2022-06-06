using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public bool result = false;
    public TMPro.TextMeshProUGUI resultText;
    public void ChangeResult(bool res)
    {
        result = res;
    }
    public void ShowPanel()
    {
        gameObject.SetActive(true);
        if (result)
        {
            resultText.text = "�����";
        } else
        {
            resultText.text = "������";
        }
    }

    public void ChangeScene()
    {
        if (result)
        {
            gameObject.SetActive(false);
        } else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResult : MonoBehaviour
{
    int result = 0;
    int answersCount = 20;
    [SerializeField] private TMPro.TextMeshProUGUI resultText;
    public void SetResult(int res)
    {
        result = res;
    }
    
    public void SetAnswersCount(int answcnt)
    {
        answersCount = answcnt;
    }

    public void SetResultText(string text)
    {
        resultText.text = text;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommitButton : MonoBehaviour
{
    [SerializeField] private QuestionPanel[] questionPanels;
    [SerializeField] private GameObject testResultPanel;
    // Start is called before the first frame update
    
    int CountRightAnswers()
    {
        int count = 0;
        foreach (QuestionPanel question in questionPanels)
        {
            if (question.IsCorrect())
            {
                count++;
            }
        }
        return count;
    }

    private string FormText()
    {
        float result = CountRightAnswers();
        float answer_count = questionPanels.Length;
        string result_text = $"¬аш результат: {result}/{answer_count} \n" +
            $"ќценка: {System.Math.Round(result/answer_count * 5.0f)}";
        return result_text;
    }

    public void Commit()
    {
        testResultPanel.GetComponent<TestResult>().SetAnswersCount(questionPanels.Length);
        testResultPanel.GetComponent<TestResult>().SetResult(CountRightAnswers());
        testResultPanel.GetComponent<TestResult>().SetResultText(FormText());
        testResultPanel.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

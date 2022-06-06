using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionPanel : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Toggle rightAnswer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool IsCorrect()
    {
        return rightAnswer.isOn;
    }
}

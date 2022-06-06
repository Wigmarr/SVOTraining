using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pump : MonoBehaviour
{
    public bool isActive = false;
    public PipeSystem[] startPipes;

    private void OnMouseDown() {
        if (!isActive) {
            Activate();
        }
        else 
        {
            DeActivate();
        }

    }
    public void Activate()
    {
        isActive = true;
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        foreach (PipeSystem pipe in startPipes)
        {
            pipe.Activate();
        }

    }
    public void DeActivate()
    {
        isActive = false;
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        foreach (PipeSystem pipe in startPipes)
        {
            pipe.DeActivate();
        }
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

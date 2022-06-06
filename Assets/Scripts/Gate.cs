using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [Header("Parts")]

    [SerializeField] private GameObject triangle1;
    [SerializeField] private GameObject triangle2;
    
    [SerializeField] private bool isOpen = false;
    [SerializeField] private bool isFake = false;
    [SerializeField] private PipeSystem inputSystem;
    [SerializeField] private PipeSystem outputSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        if (isOpen) 
        {
            if (isOpen) {
                triangle1.GetComponent<SpriteRenderer>().color = Color.green;
                triangle2.GetComponent<SpriteRenderer>().color = Color.green;
            }
            else {
                triangle1.GetComponent<SpriteRenderer>().color = Color.white;
                triangle2.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }

    private void Update()
    {
        if (!isFake)
        {
            if (isOpen)
            {
                if (inputSystem.isActive)
                {
                    outputSystem.Activate();
                }
                else
                {
                    outputSystem.DeActivate();
                }
            }
            else
            {
                outputSystem.DeActivate();
            }
        }

    }
    public void Activate()
    {
        isOpen = true;
        triangle1.GetComponent<SpriteRenderer>().color = Color.green;
        triangle2.GetComponent<SpriteRenderer>().color = Color.green;
    }

    public void DeActivate()
    {
        isOpen = false;
        triangle1.GetComponent<SpriteRenderer>().color = Color.white;
        triangle2.GetComponent<SpriteRenderer>().color = Color.white;
    }
    public void ChangeState() {

        isOpen = !isOpen;
        if (isOpen)
        {
            triangle1.GetComponent<SpriteRenderer>().color = Color.green;
            triangle2.GetComponent<SpriteRenderer>().color = Color.green;

        }
        else
        {
            triangle1.GetComponent<SpriteRenderer>().color = Color.white;
            triangle2.GetComponent<SpriteRenderer>().color = Color.white;
        }

    }

    private void OnMouseDown() {
        ChangeState();
    }

    public bool IsOpen() {
        return isOpen;
    }
}

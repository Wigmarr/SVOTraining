using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSystem : MonoBehaviour
{
    public Animator animator;
    public bool isActive = false;
    public GameObject[] waterPipes;
    public GameObject spritePipe = null;
    // Start is called before the first frame update
    void Start()
    { 

    }

    public void Activate()
    {
        isActive = true;
        if (animator != null)
        {
            animator.SetTrigger("trStart");
        }
        foreach (GameObject pipe in waterPipes)
        {
            pipe.GetComponent<ChangeColor>().Activate();
        }
        if (spritePipe != null)
        {
            spritePipe.GetComponent<ChangeColorSprite>().Activate();
        }
    }

    public void DeActivate()
    {
        isActive = false;

        if (animator != null)
        {
            animator.SetTrigger("trStop");
        }
        foreach (GameObject pipe in waterPipes)
        {
            pipe.GetComponent<ChangeColor>().DeActivate();
        }
        if (spritePipe != null)
        {
            spritePipe.GetComponent<ChangeColorSprite>().DeActivate();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

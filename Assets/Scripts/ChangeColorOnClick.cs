using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    public Color color = Color.white;
    public bool isActive = false;
    private void OnMouseDown()
    {
        if (!isActive)
        {
            isActive = true;
            gameObject.GetComponent<SpriteRenderer>().color = color;
        }
        else
        {
            isActive = false;
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}

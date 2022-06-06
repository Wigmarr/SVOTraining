using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    bool isActive = false;
    Color lerpedColor = Color.white;
    public Color startColor = Color.blue;
    public Color endColor = Color.cyan;
    [SerializeField] private MeshRenderer meshRenderer;
    // Update is called once per frame
    void Update()
    {
        if (isActive) {
            lerpedColor = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time, 1));
            meshRenderer.material.color = lerpedColor;
        }
    }
    private void SetDefaultColor()
    {
        meshRenderer.material.color = startColor;
    }

    public void DeActivate()
    {
        isActive = false;
        SetDefaultColor();
    }
    public void Activate()
    {
        isActive = true;
    }
}

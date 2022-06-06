using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class ChangeColorSprite : MonoBehaviour
{
    bool isActive = false;
    Color lerpedColor = Color.white;
    public Color startColor = Color.blue;
    public Color endColor = Color.cyan;
    [SerializeField] private SpriteShapeRenderer spriteRenderer;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update() {
        if (isActive)
        {
            lerpedColor = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time, 1));
            spriteRenderer.color = lerpedColor;
        }
    }

    private void SetDefaultColor()
    {
        spriteRenderer.color = startColor;
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

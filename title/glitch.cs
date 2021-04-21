using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class glitch : MonoBehaviour
{
    [SerializeField] Material material = null;
    SpriteRenderer spriteRenderer;

    float seconds;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.material = new Material(material);
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if(seconds >= 5)
        {
            var glitchscale = 0.15f;
            spriteRenderer.material.SetFloat("_GlitchScale", glitchscale);
        }
        if(seconds >= 8)
        {
            var glitchscale = 0.05f;
            spriteRenderer.material.SetFloat("_GlitchScale", glitchscale);
        }
        if (seconds >= 10)
        {
            var glitchscale = 0f;
            spriteRenderer.material.SetFloat("_GlitchScale", glitchscale);
        }

    }
}

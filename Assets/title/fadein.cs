using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadein : MonoBehaviour
{
    Image fadeImage;
    private float red, green, blue, alfa;

    public float fadespeed = 0.02f;

    public bool isFadeIn = true;

    // Start is called before the first frame update
    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn)
        {
            StartFadeIn();
        }
    }

    void StartFadeIn()
    {
        //fadeImage.enabled = true;
        alfa -= fadespeed;
        SetAlfa();
        if(alfa <= 0)
        {
            isFadeIn = false;
            fadeImage.enabled = false;
        }
    }

    void SetAlfa()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}

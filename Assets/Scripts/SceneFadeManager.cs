using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFadeManager : MonoBehaviour
{
    private bool isFadeOut = false;
    private bool isFadeIn = true;

    float fadeSpeed = 0.5f;

    public Image fadeImage;

    float red, green, blue, alfa;

    string afterScene;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        SetRGBA(0, 0, 0, 1);

        SceneManager.sceneLoaded += fadeInStart;
    }

    void fadeInStart(Scene scene, LoadSceneMode mode)
    {
        isFadeIn = true;
    }

    public void fadeOutStart(int red, int green, int blue, int alfa, string nextScene)
    {
        SetRGBA(red, green, blue, alfa);
        SetColor();
        isFadeOut = true;
        afterScene = nextScene;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn == true)
        {
            alfa -= fadeSpeed * Time.deltaTime;
            SetColor();

            if (alfa <= 0)
            {
                isFadeIn = false;

            }
        }

        if (isFadeOut == true)
        {
            alfa += fadeSpeed * Time.deltaTime;

            SetColor();
            if (alfa >= 1)
            {
                isFadeOut = false;
                SceneManager.LoadScene(afterScene);
            }
        }
    }

    void SetColor()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }

    public void SetRGBA(int r, int g, int b, int a)
    {
        red = r;
        green = g;
        blue = b;
        alfa = a;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    // フェードインのおおよその秒数
    [SerializeField]
    private float fadeInTime;
    // 背景Image
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = transform.Find("Panel").GetComponent<Image>();
        // コルーチンで使用する待ち時間を計測
        fadeInTime = 1f * fadeInTime / 100f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator fadeIn()
    {
        yield return new WaitForSeconds(1.7f);
        // Colorのアルファを0.1ずつ下げていく
        for (var i = 1f; i >= 0; i -= 0.01f)
        {
            image.color = new Color(0.1176471f, 0.1176471f, 0.1176471f, i);
            // 指定秒数待つ
            yield return new WaitForSeconds(fadeInTime);
        }
    }

    public void fade_In()
    {
        StartCoroutine("fadeIn");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeOut : MonoBehaviour
{
    // フェードインのおおよその秒数
    [SerializeField]
    private float fadeOutTime;
    // 背景Image
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = transform.Find("Panel").GetComponent<Image>();
        // コルーチンで使用する待ち時間を計測
        fadeOutTime = 1f * fadeOutTime / 100f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator fadeOut_coroutine()
    {
        yield return new WaitForSeconds(1.7f);
        // Colorのアルファを0.1ずつ下げていく
        for (float i = 0f; i <= 1f; i += 0.01f)
        {
            image.color = new Color(0.1176471f, 0.1176471f, 0.1176471f, i);
            // 指定秒数待つ
            yield return new WaitForSeconds(fadeOutTime);
        }
    }

    public void fade_out()
    {
        StartCoroutine("fadeOut_coroutine");
    }
}
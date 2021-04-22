using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlider_2nd : MonoBehaviour
{
    // 最大時間と現在時間
    float maxTime = 3.0f;
    public static float currentTime;
    public bool stop_flag = true;
    float time;

    // Sliderを入れる
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        // Sliderを満タンにする
        slider.value = 1;

        // 現在時間と最大時間を同じに
        currentTime = maxTime;
        Debug.Log("time: " + currentTime);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public float countdown()
    {
        // 最大時間から経過時間を引く
        currentTime -= Time.deltaTime;
        // 最大時間における残りの時間をSliderに反映
        slider.value = (float)currentTime / (float)maxTime;
        // Debug.Log("time: " + currentTime);

        return currentTime;
    }

    public void count_reset()
    {
        // currentTimeの足し引きを0にする
        currentTime = 3.0f;
    }
}

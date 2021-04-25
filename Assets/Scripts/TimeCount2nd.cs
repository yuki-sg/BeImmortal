using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ストップウォッチ

public class TimeCount2nd : MonoBehaviour
{
    // シーンで共有するストップウォッチ
    public static float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        time = TimeCount.getTime();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);
    }

    public static float getTime()
    {
        return time;
    }
}

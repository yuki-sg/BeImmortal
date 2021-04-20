using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ストップウォッチ

public class TimeCount : MonoBehaviour
{
    // シーンで共有するストップウォッチ
    public static int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        time = (int)Time.time;
    }

    public static int getTime()
    {
        return time;
    }
}

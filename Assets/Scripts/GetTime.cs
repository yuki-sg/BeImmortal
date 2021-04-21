using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 測った時間を受け取る

public class GetTime : MonoBehaviour
{
    // 測った時間を受け取る変数
    float time;

    // 別階層のテキストUIを見つける
    public Text TimeText;

    // 文字列表示
    private Text UIJ;

    // Start is called before the first frame update
    void Start()
    {
        time = TimeCount2nd.getTime();
        print(time);

        UIJ = TimeText;
        UIJ.text = time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

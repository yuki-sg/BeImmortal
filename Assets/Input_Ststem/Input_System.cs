using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Input_System : MonoBehaviour
{
    //　文字列のパターン
    private string[] qJ  = {"abyxybax", "ybaxxabx", "yaabxyab","bxayaxyb","yxbyxbax"};
   
    //　文字列表示
    private Text UIJ;
   
    //　日本語問題
    private string nQJ;
    
    //　問題番号
    private int num;
    
    //何文字目か
    private int index;
    private Text UIJC;
    void Start()
    {
        //　テキストUIを取得
        UIJ = transform.Find("InputObject/Text").GetComponent<Text>();
        
        OutPut();

    }

    void OutPut()
    {
        //　問題数内でランダムに選ぶ
        num = Random.Range(0, qJ.Length);
 
        //　選択した問題をテキストUIにセット
        nQJ = qJ[num];
        
        UIJ.text = nQJ;
        
    }

    void Update()
    {
        //　キーを押しているかどうか
        if(Input.anyKeyDown
           && (!Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
        ) {
            //　今見ている文字とキーボードから打った文字が同じかどうか
            if(Input.GetKeyDown(nQJ[index].ToString())) {
                //　正解時の処理を呼び出す
                Correct();
            } else {
                //　失敗時の処理を呼び出す
                Mistake();
            }
        }
        
        //　タイピング正解時の処理
        void Correct()
        {
            index++;
            if(index >= nQJ.Length)
            {
                Debug.Log("攻撃させていただきますわwwwww");
            }
        }
 
        //　タイピング失敗時の処理
        void Mistake() {
            Debug.Log("ミスってるでwwwww");
        }
    }
}



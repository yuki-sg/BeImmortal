using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Input_System : MonoBehaviour
{
    //　文字列のパターン
    private string[] qJ  = {"","a","b","x","y"};
   
    //　文字列表示
    private Text UIJ;
   
    //　日本語問題
    private string nQJ;
    
    //　問題番号
    private int num;
    
    //何文字目か
    private int index;
    private Text UIJC;

    private int count = 0;
    private bool Input_Flag = true;
    void Start()
    { 
        //　テキストUIを取得
        UIJ = transform.Find("InputObject/Text").GetComponent<Text>();
        OutPut();
        
    }

    void OutPut()
    {
        //　問題数内でランダムに選ぶ
        num = Random.Range(1, qJ.Length);
 
        //　選択した問題をテキストUIにセット
        nQJ = qJ[num];
        
        UIJ.text = nQJ;
        
    }

    void Update()
    {
        if (count != 8 && Input_Flag)
        {
            //　キーを押しているかどうか
            if (Input.anyKeyDown
                && (!Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
            )
            {
                //　今見ている文字とキーボードから打った文字が同じかどうか


                if (Input.GetKeyDown(nQJ[index].ToString()))
                {
                    count++;
                    OutPut();
                }
                else
                {
                    //　失敗時の処理を呼び出す
                    Mistake();
                }

            }
        }
        else if(count == 8)
        {
            Correct();
        }

    }

    

    //　タイピング正解時の処理
        void Correct()
        {
            Debug.Log("攻撃させていただきますわwwwww");
            count = 0;
            UIJ.text = qJ[0];
            Input_Flag = false;
        }

        //　タイピング失敗時の処理
        void Mistake()
        {
            Debug.Log("ミスってるでwwwww");
        }

    }



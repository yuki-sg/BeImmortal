using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleButtonInput : MonoBehaviour
{
    //　文字列表示
    private Text UIJ0, UIJ1, UIJ2, UIJ3;

    //　日本語問題
    private string[] nQJ = new string[4];

    private int count = 0;
    private bool Input_Flag = true;

    // 入力成功後の動作を1回きりにしたい
    public bool OnceCorrect = true;

    // 別階層のテキストUIを見つける
    public Text text0;
    public Text text1;
    public Text text2;
    public Text text3;

    // load_tutorialのnextScene()のためのGameObject
    public GameObject load;

    void OutPut0()
    {
        //　選択した問題をテキストUIにセット
        nQJ[0] = "a";
        // 文字入力は小文字だが、表示は大文字にみせるためのToUpper()
        UIJ0.text = nQJ[0].ToUpper();
    }

    void Output1()
    {
        nQJ[1] = "b";
        UIJ1.text = nQJ[1].ToUpper();
    }

    void Output2()
    {
        nQJ[2] = "x";
        UIJ2.text = nQJ[2].ToUpper();
    }

    void Output3()
    {
        nQJ[3] = "y";
        UIJ3.text = nQJ[3].ToUpper();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        input_system();
    }

    //　タイピング正解時の処理
    void Correct()
    {
        Debug.Log("入力成功");
        isCalledOnce = false;
    }

    //　タイピング失敗時の処理
    void Mistake()
    {
        Debug.Log("入力失敗");

        count = 0;
        UIJ0.text = "";
        UIJ1.text = "";
        UIJ2.text = "";
        UIJ3.text = "";

        isCalledOnce = false;
    }

    // update内で1度だけ実行するためのフラグ
    private bool isCalledOnce = false;
    public void input_system()
    {
        // 4文字が打ち終わったかどうかを判断する
        bool CorrectFlag = false;
        if (!CorrectFlag)
        {
            if (!isCalledOnce)
            {
                isCalledOnce = true;
                UIJ0 = text0; // transform.Find("Canvas/InputObject/Text").GetComponent<Text>();
                UIJ1 = text1;
                UIJ2 = text2;
                UIJ3 = text3;
                nQJ[0] = "a";
                nQJ[1] = "b";
                nQJ[2] = "x";
                nQJ[3] = "y";
            }

            // 4文字が打ち終わるまでのシステム
            if (count <= 3)
            {
                //　キーを押しているかどうか
                if (Input.anyKeyDown
                && (!Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
                )
                {
                    //　今見ている文字とキーボードから打った文字が同じかどうか
                    if (Input.GetKeyDown(nQJ[count]))
                    {
                        // ここでテキストが表示されるようにしたい
                        switch (count)
                        {
                            case 0:
                                UIJ0.text = nQJ[0].ToUpper();
                                break;
                            case 1:
                                UIJ1.text = nQJ[1].ToUpper();
                                break;
                            case 2:
                                UIJ2.text = nQJ[2].ToUpper();
                                break;
                            case 3:
                                UIJ3.text = nQJ[3].ToUpper();
                                break;
                        }
                        count++;
                    }
                    // 文字を打ち間違えた場合ーーその瞬間失敗となる
                    else
                    {
                        Mistake();
                        // ABXY連続入力失敗
                    }
                }
            }
            else if (count > 3)
            {
                if (OnceCorrect)
                {
                    OnceCorrect = false;
                    Correct();
                    // ABXY連続入力成功
                    CorrectFlag = true;
                    load.GetComponent<load_tutorial>().nextScene();
                }
            }
        }
    }
}

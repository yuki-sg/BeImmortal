using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BTInput1st : MonoBehaviour
{
    //　文字列のパターンーー大文字ABXYでは文字入力を受け付けないのはなぜ？
    private string[] qJ = { "", "a", "b", "x", "y" };

    //　文字列表示
    private Text UIJ0, UIJ1, UIJ2, UIJ3, UIJ4, UIJ5, UIJ6, UIJ7;

    //　日本語問題
    private string[] nQJ = new string[8];

    //　問題番号
    private int num0, num1, num2, num3, num4, num5, num6, num7;

    private int count = 0;
    private bool Input_Flag = true;

    // playerHpBarのGameObject
    public GameObject playerHpBar;
    // enemyHPBarのGameObject
    public GameObject enemyHpBar;
    // player_motionのattack(), enemy_blinkerのenemy_blinkのためのGameObject
    public GameObject player;
    // motion_1stEnemyのattack(), enemy_blinkerのenemy_blink()のためのGameObject
    public GameObject enemy;
    // timeSliderのcountdown()のためのGameObject
    public GameObject time_slider;
    // fadeOutのfade_out()のためのGameObject
    public GameObject fade_out;

    // Load_1stのnextScene()のためのGameObject
    public GameObject load;

    // 別階層のテキストUIを見つける
    public Text text;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;

    void OutPut0()
    {
        //　問題数内でランダムに選ぶ
        num0 = Random.Range(1, qJ.Length);

        //　選択した問題をテキストUIにセット
        nQJ[0] = qJ[num0];
        // 文字入力は小文字だが、表示は大文字にみせるためのToUpper()
        UIJ0.text = nQJ[0].ToUpper();
    }

    void Output1()
    {
        num1 = Random.Range(1, qJ.Length);
        nQJ[1] = qJ[num1];
        UIJ1.text = nQJ[1].ToUpper();
    }

    void Output2()
    {
        num2 = Random.Range(1, qJ.Length);
        nQJ[2] = qJ[num2];
        UIJ2.text = nQJ[2].ToUpper();
    }

    void Output3()
    {
        num3 = Random.Range(1, qJ.Length);
        nQJ[3] = qJ[num3];
        UIJ3.text = nQJ[3].ToUpper();
    }

    void Output4()
    {
        num4 = Random.Range(1, qJ.Length);
        nQJ[4] = qJ[num4];
        UIJ4.text = nQJ[4].ToUpper();
    }

    void Output5()
    {
        num5 = Random.Range(1, qJ.Length);
        nQJ[5] = qJ[num5];
        UIJ5.text = nQJ[5].ToUpper();
    }

    void Output6()
    {
        num6 = Random.Range(1, qJ.Length);
        nQJ[6] = qJ[num6];
        UIJ6.text = nQJ[6].ToUpper();
    }

    void Output7()
    {
        num7 = Random.Range(1, qJ.Length);
        nQJ[7] = qJ[num7];
        UIJ7.text = nQJ[7].ToUpper();
    }

    void Start()
    {
        // UnityのGUIに取得を任せたーー親子関係にないオブジェクトを取得できるのかわからなくなったため
        // playerHpBar = GameObject.Find("hpBar_system");
        // enemyHpBar = GameObject.Find("enemyHpBar_system");
        // player = GameObject.Find("Canvas/testPanel/player");
        // enemy = GameObject.Find("Canvas/testPanel/1stEnemy");
        // time_slider = GameObject.Find("timeSlider_system");
        fade_out = GameObject.Find("fade");
    }

    void Update()
    {
    }

    //　タイピング正解時の処理
    void Correct()
    {
        Debug.Log("攻撃");

        count = 0;
        isCalledOnce = false;
    }

    //　タイピング失敗時の処理
    void Mistake()
    {
        Debug.Log("被攻撃");

        count = 0;
        UIJ0.text = qJ[0];
        UIJ1.text = qJ[0];
        UIJ2.text = qJ[0];
        UIJ3.text = qJ[0];
        UIJ4.text = qJ[0];
        UIJ5.text = qJ[0];
        UIJ6.text = qJ[0];
        UIJ7.text = qJ[0];

        isCalledOnce = false;
    }

    // enemyHPBar.hp_decrease()の戻り値からHPを取得する
    int enemy_hp = 155;
    // playerHPBar.hp_decrease()の戻り値からHPを取得する
    int player_hp = 155;

    // update内で1度だけ実行するためのフラグ
    private bool isCalledOnce = false;
    public void input_system()
    {

        if (enemy_hp > 0 && player_hp > 0)
        {
            // ここに time = countdown();
            float time = time_slider.GetComponent<timeSlider>().countdown();
            if (time <= 0)
            {
                Input_Flag = false;
                count = 8;
            }

            // 最初に配置するランダムな8文字ーー1回きりにしないとフレームごとに乱数が更新される
            if (!isCalledOnce)
            {
                isCalledOnce = true;
                //　テキストUIを取得
                UIJ0 = text; // transform.Find("Canvas/InputObject/Text").GetComponent<Text>();
                UIJ1 = text1; // transform.Find("Canvas/InputObject/Text1").GetComponent<Text>();
                UIJ2 = text2; // transform.Find("Canvas/InputObject/Text2").GetComponent<Text>();
                UIJ3 = text3; // transform.Find("Canvas/InputObject/Text3").GetComponent<Text>();
                UIJ4 = text4; // transform.Find("Canvas/InputObject/Text4").GetComponent<Text>();
                UIJ5 = text5; // transform.Find("Canvas/InputObject/Text5").GetComponent<Text>();
                UIJ6 = text6; // transform.Find("Canvas/InputObject/Text6").GetComponent<Text>();
                UIJ7 = text7; // transform.Find("Canvas/InputObject/Text7").GetComponent<Text>();
                OutPut0();
                Output1();
                Output2();
                Output3();
                Output4();
                Output5();
                Output6();
                Output7();
            }

            // 8文字が打ち終わるまでのシステム
            if (count <= 7 && Input_Flag)
            {
                //　キーを押しているかどうか
                if (Input.anyKeyDown
                && (!Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
                || Input.GetButtonDown("a") || Input.GetButtonDown("b")
                || Input.GetButtonDown("x") || Input.GetButtonDown("y"))
                {
                    //　今見ている文字とキーボードから打った文字が同じかどうか
                    if (Input.GetKeyDown(nQJ[count]) || Input.GetButtonDown(nQJ[count]))
                    {
                        Debug.Log("合ってる");
                        switch (count)
                        {
                            case 0:
                                UIJ0.text = qJ[0];
                                break;
                            case 1:
                                UIJ1.text = qJ[0];
                                break;
                            case 2:
                                UIJ2.text = qJ[0];
                                break;
                            case 3:
                                UIJ3.text = qJ[0];
                                break;
                            case 4:
                                UIJ4.text = qJ[0];
                                break;
                            case 5:
                                UIJ5.text = qJ[0];
                                break;
                            case 6:
                                UIJ6.text = qJ[0];
                                break;
                            case 7:
                                UIJ7.text = qJ[0];
                                break;
                            default:
                                Debug.Log("うまくいってない");
                                break;
                        }
                        count++;
                    }
                    // 文字を打ち間違えた場合ーーその瞬間失敗となる
                    else
                    {
                        count = 8;
                        Input_Flag = false;
                    }
                }
            }
            // Input_Flagで成功と失敗を見分けている
            else if (count > 7 && Input_Flag)
            {
                // ここに current_time=0 を入れる
                // もしくは時間を止める
                time_slider.GetComponent<timeSlider>().count_reset();

                Correct();
                // enemyHPBar.csのメソッドhp_decrease()を実行
                enemy_hp = enemyHpBar.GetComponent<enemyHPBar>().hp_decrease();
                Debug.Log("enemy_hp: " + enemy_hp);

                bool once_attack = false;
                if (!once_attack)
                {
                    once_attack = true;

                    player.GetComponent<player_motion>().attack();
                    enemy.GetComponent<enemy_blinker>().enemy_blink();
                }
            }
            else if (count > 7 && !Input_Flag)
            {
                // ここに current_time=0 を入れる
                // もしくは時間を止める
                time_slider.GetComponent<timeSlider>().count_reset();

                Mistake();
                // playerHPBar.csのメソッドhp_decrease()を実行
                player_hp = playerHpBar.GetComponent<playerHPBar>().hp_decrease();
                Debug.Log("player_hp: " + player_hp);
                Input_Flag = true;

                bool once_attack = false;
                if (!once_attack)
                {
                    once_attack = true;

                    enemy.GetComponent<motion_1stEnemy>().attack();
                    player.GetComponent<enemy_blinker>().enemy_blink();
                }
            }
        }
        else if (enemy_hp <= 0)
        {
            if (!isCalledOnce)
            {
                isCalledOnce = true;
                Debug.Log("WIIIIIIN");

                // ここにフェードアウトもしくはシーン遷移
                fade_out.GetComponent<fadeOut>().fade_out();
                load.GetComponent<Load_2nd>().nextScene();
            }
            enemy.GetComponent<enemy_blinker>().disappear();
        }
        else if (player_hp <= 0)
        {
            if (!isCalledOnce)
            {
                isCalledOnce = true;
                Debug.Log("LOOOOOSE");

                // ここにフェードアウトもしくはシーン遷移
                fade_out.GetComponent<fadeOut>().fade_out();
            }
            player.GetComponent<enemy_blinker>().disappear();
        }
    }
}



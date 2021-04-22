using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp_2nd : MonoBehaviour
{
    // 最大HPと現在のHP
    int maxHp = 155;
    public static int player_currentHp;

    //Sliderを入れる
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        //Sliderを満タンにする
        slider.value = 1;

        //現在のHPを最大HPと同じに
        player_currentHp = maxHp;
        Debug.Log("Start currentHp: " + player_currentHp);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // HPゲージが減少するタイミングを調整　！！！うまく機能していない！！！
    IEnumerator wait_coroutine()
    {
        yield return new WaitForSeconds(2);
    }

    // button_inputクラスのinput_systemの
    // Mistakeメソッドと以下のメソッドを置き換える
    public int hp_decrease()
    {
        StartCoroutine("wait_coroutine");

        // ダメージは1~100の中でランダムに決める
        int damage = Random.Range(25, 75);
        Debug.Log("damage: " + damage);

        // 現在のHPからダメージを引く
        player_currentHp = player_currentHp - damage;
        Debug.Log("after currentHp: " + player_currentHp);

        // 最大HPにおける現在のHPをSliderに反映
        // intどうしの割り算は小数点以下は0になるので、
        // (float)をつけてfloatの変数として振舞わせる
        slider.value = (float)player_currentHp / (float)maxHp;
        Debug.Log("slider.value: " + slider.value);

        return player_currentHp;
    }
}

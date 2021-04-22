using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHp_2nd : MonoBehaviour
{
    // 最大HPと現在のHP
    int maxHp = 310;
    public static int enemy_currentHp;

    //Sliderを入れる
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        //Sliderを満タンにする
        slider.value = 1;

        //現在のHPを最大HPと同じに
        enemy_currentHp = maxHp;
        Debug.Log("Start enemy currentHp: " + enemy_currentHp);
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
        int damage = Random.Range(20, 50);
        Debug.Log("enemy damage: " + damage);

        // 現在のHPからダメージを引く
        enemy_currentHp = enemy_currentHp - damage;
        Debug.Log("after enemy currentHp: " + enemy_currentHp);

        // 最大HPにおける現在のHPをSliderに反映
        // intどうしの割り算は小数点以下は0になるので、
        // (float)をつけてfloatの変数として振舞わせる
        slider.value = (float)enemy_currentHp / (float)maxHp;
        Debug.Log("enemy slider.value: " + slider.value);

        return enemy_currentHp;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_blinker : MonoBehaviour
{
    // 自身のスプライト
    private SpriteRenderer _Sprite;

    // 点滅カウント
    private uint _flashCount;
    // 点滅用透過度
    private float _flashAlpha;

    // Start is called before the first frame update
    void Start()
    {
        // スプライトのレンダリングとその制御ーーここにカラーもある
        _Sprite = transform.GetComponent<SpriteRenderer>();
        _flashCount = 0;
        _flashAlpha = 1;
    }

    bool isCalledOnce = true;

    // Update is called once per frame
    void Update()
    {
        
    }

    // コルーチンで点滅のスピードを制御
    IEnumerator blink_coroutine()
    {
        yield return new WaitForSeconds(0.5f);

        float T = 0.01f;     // 周期
        float f = 1.0f / T; // 周波数

        // 透明度を適用する
        Color _color = _Sprite.color;

        for (_flashCount = 0; _flashCount < 4; _flashCount++)
        {
            _flashAlpha = 0;
            _color.a = _flashAlpha; // color.aは透過度ーーこれを変動させることで点滅
            _Sprite.color = _color; // .aまで付けてもたぶんいけるーー面倒なのでcolor(RGBA)すべてを代入

            // Debug.Log("_flashAlpha: " + _flashAlpha + " count: " + _flashCount);

            yield return new WaitForSeconds(0.15f);

            // 透明度を時間によってsin波で決める
            // 2で割ると-0.5~0.5, +0.5fで0~1に
            // Time.timeが変数として機能している
            // _flashAlpha = Mathf.Sin(2 * Mathf.PI * f * Time.time) / 2 + 0.5f;

            _flashAlpha = 1;
            _color.a = _flashAlpha; // color.aは透過度ーーこれを変動させることで点滅
            _Sprite.color = _color; // .aまで付けてもたぶんいけるーー面倒なのでcolor(RGBA)すべてを代入

            // Debug.Log("_flashAlpha: " + _flashAlpha + " count: " + _flashCount);

            yield return new WaitForSeconds(0.15f);
        }
    }

    // ここだけで1巡の点滅(0.2秒ごとを5回)を実現したい
    public void enemy_blink()
    {
        StartCoroutine("blink_coroutine");

        // 点滅カウントが一定を越えたら解除する
        // フラッシュカウントをリセット
        _flashCount = 0;
        // プレイヤーの透明度を戻す
        _Sprite.color = new Color(255, 255, 255, 255);
    }

    // コルーチンで消滅のタイミングを調節
    IEnumerator disappear_coroutine()
    {
        // 透明度を適用する
        Color _color = _Sprite.color;

        yield return new WaitForSeconds(1.7f);
        _flashAlpha = 0;
        _color.a = _flashAlpha;
        _Sprite.color = _color;

    }

    public void disappear()
    {
        StartCoroutine("disappear_coroutine");
    }
}

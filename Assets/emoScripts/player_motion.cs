using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_motion : MonoBehaviour
{
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalKey = Input.GetAxis ("Horizontal");

    }

    // 右側へ歩行する
    public void walk()
    {
        // transformを取得
        Transform playerTransform = this.transform;

        anim.SetBool("walk", true);

        // 座標を取得
        Vector3 pos = playerTransform.position;
        pos.x += 0.01f;

        playerTransform.position = pos;
    }

    // 停止する
    public void stop()
    {
        // transformを取得
        Transform playerTransform = this.transform;

        anim.SetBool("walk", false);

        // 座標を取得
        Vector3 pos = playerTransform.position;
        pos.x -= 0.01f;

        playerTransform.position = pos;
    }

    // コルーチンで攻撃を1回に制御
    IEnumerator once_attack_coroutine()
    {
        anim.SetBool("attack", true);

        // 0.55秒(1回の攻撃にかかる時間)待つ
        yield return new WaitForSeconds(1);

        anim.SetBool("attack", false);
    }

    // 攻撃する
    public void attack()
    {
        StartCoroutine("once_attack_coroutine");
    }
}
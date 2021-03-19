using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion_1stEnemy : MonoBehaviour
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
        float horizonalKey = Input.GetAxis("Horizontal");

    }

    public void walk()
    {
        Transform enemyTransform = this.transform;

        anim.SetBool("walk", true);

        Vector3 pos = enemyTransform.position;
        pos.x -= 0.01f;

        enemyTransform.position = pos;
    }

    public void stop()
    {
        Transform enemyTransform = this.transform;

        anim.SetBool("walk", false);

        Vector3 pos = enemyTransform.position;
        pos.x += 0.01f;

        enemyTransform.position = pos;
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

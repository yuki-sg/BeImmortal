using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{

    Rigidbody2D rigid2D;
    Animator animator;
    float walk = 10.0f;
    float maxSpeed = 2.0f;



    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        int key = 0;

        //プレイヤの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //スピード制限
        if (speedx < this.maxSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walk);

        }

        //プレイヤの速度に応じてアニメーション速度を変える
        this.animator.speed = speedx / 2.0f;
    }
}

    

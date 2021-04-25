using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    private Animator anim;
    GameObject Player;
    GameObject Enemy;


    // Start is called before the first frame update
    void Start()
    {
        /*
        anim = gameObject.GetComponent<Animator>();
        */
        this.Player = GameObject.Find("Player");
        this.Enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("blwalk", true);
        }
        else if (Input.GetKey(KeyCode.F1))
        {
            anim.SetBool("blattack", false);
        }
 */

        //当たり判定
        Vector2 p1 = this.Enemy.transform.position;
        Vector2 p2 = this.Player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;
        float r2 = 1.0f;
    }
}


   

    

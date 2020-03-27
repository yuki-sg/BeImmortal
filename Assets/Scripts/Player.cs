using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

  /*  public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player();
        myPlayer.Attack();
        /*
        myPlayer.Damage(20);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance2nd : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy1st;
    public GameObject input_system;

    // player_motionのwalk()のためのGameObject
    public GameObject player_walk;
    // motion_1stEnemyのwalk()のためのGameObject
    public GameObject enemy_walk;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        enemy1st = GameObject.Find("1stEnemy");
        input_system = GameObject.Find("input_system");
        player_walk = GameObject.Find("Canvas/testPanel/player");
        enemy_walk = GameObject.Find("Canvas/testPanel/1stEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 player_pos = player.transform.position;
        Vector3 enemy1st_pos = enemy1st.transform.position;
        float dis = Vector3.Distance(player_pos, enemy1st_pos);

        bool input_flag = true;

        if (input_flag)
        {
            player_walk.GetComponent<player_motion>().walk();
            enemy_walk.GetComponent<motion_1stEnemy>().walk();

            if (dis <= 5.5)
            {
                // button_input.csのメソッドinput_system()を実行
                input_system.GetComponent<BTInput2nd>().input_system();

                input_flag = false;

                player_walk.GetComponent<player_motion>().stop();
                enemy_walk.GetComponent<motion_1stEnemy>().stop();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("blwalk", true);
        }
        else if (Input.GetKey(KeyCode.F1))
        {
            anim.SetBool("blattack", false);
        }
 
    }
}


   

    

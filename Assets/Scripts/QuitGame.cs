using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Quit() 
    {
        Application.Quit ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Escape)) {
            Quit ();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Tutorial : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("TutorialScene");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Tutorial : MonoBehaviour
{

    public void OnClick()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}

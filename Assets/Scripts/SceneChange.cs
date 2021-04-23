using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    GameObject ManageObject;
    SceneFadeManager fadeManager;
    // Start is called before the first frame update
    void Start()
    {
        ManageObject = GameObject.Find("ManageObject");

        fadeManager = ManageObject.GetComponent<SceneFadeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {// Scene 遷移
            fadeManager.fadeOutStart(0, 0, 0, 0, "");
        }
    }
}

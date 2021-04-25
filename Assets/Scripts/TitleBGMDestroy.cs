using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBGMDestroy : MonoBehaviour
{
    public GameObject TitleBGM;

    // Start is called before the first frame update
    void Start()
    {
        TitleBGM = GameObject.Find("TitleBGM");
        Destroy(TitleBGM);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

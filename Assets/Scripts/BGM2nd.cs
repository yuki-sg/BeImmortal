using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM2nd : MonoBehaviour
{
    public GameObject Bgm2nd;

    // Start is called before the first frame update
    void Start()
    {
        Bgm2nd = GameObject.Find("BGM2nd");
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Bgm2nd", 2);
    }
}

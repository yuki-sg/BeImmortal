using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarCtrl : MonoBehaviour
{
    Slider _slider;
    // Start is called before the first frame update
    void Start()
    {
        _slider = GameObject.Find ("Slider").GetComponent<Slider>();
    }

    float _hp = 1;
    // Update is called once per frame
    void Update()
    {
        _hp -= 0.01f;
        if (_hp < 0) {
            _hp = 1;
        }

        _slider.value = _hp;
    }
}

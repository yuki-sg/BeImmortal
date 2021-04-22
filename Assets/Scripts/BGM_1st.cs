using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_1st : MonoBehaviour
{
    public AudioClip sound1;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("PlayBGM", 3);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PlayBGM()
    {
        audioSource.PlayOneShot(sound1);
    }

}

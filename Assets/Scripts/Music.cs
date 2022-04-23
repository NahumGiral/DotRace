using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Music : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        if(Globle.isPlaying == true)
        {
            audio.enabled = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Globle.isPlaying == false)
        {
            audio.enabled = false;
        }
    }
}

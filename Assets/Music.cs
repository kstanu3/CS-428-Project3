using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource audio;
    public void isOn()
    {
        if(audio.isPlaying)
        {
            audio.Stop();
        }
        else
        {
            audio.Play();
        }
    }
}

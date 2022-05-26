using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;

    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            audio.PlayOneShot(sound01);
        }
        else if (other.gameObject.tag == "Target")
        {
            audio.PlayOneShot(sound02);
        }
        else audio.PlayOneShot(sound03);
    }
}


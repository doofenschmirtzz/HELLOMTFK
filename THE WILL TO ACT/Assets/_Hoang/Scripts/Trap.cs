using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {

    public AudioClip runNowSfx;

    private GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void playSfx(AudioClip _sfx)
    {
        GetComponent<AudioSource>().clip = _sfx;
        if (!GetComponent<AudioSource>().isPlaying)
            GetComponent<AudioSource>().Play();
    }
}

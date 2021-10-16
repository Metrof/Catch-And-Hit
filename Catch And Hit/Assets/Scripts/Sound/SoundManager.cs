using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource sourse;

    static public bool Lose;
    void Awake()
    {
        Lose = false;
        sourse = GetComponent<AudioSource>();
        Invoke("Active", 3.5f);
    }

    private void Active()
    {
        sourse.Play();
    }

    private void Update()
    {
        if (Lose)
        {
            sourse.mute = true;
        }
    }
}

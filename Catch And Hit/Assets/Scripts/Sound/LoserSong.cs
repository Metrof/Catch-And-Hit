using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoserSong : MonoBehaviour
{
    AudioClip gameOver;
    AudioSource sourse;

    bool YouAlreadyPlay;

    void Awake()
    {
        YouAlreadyPlay = false;
        sourse = GetComponent<AudioSource>();
        gameOver = Resources.Load<AudioClip>("GameOver4");
    }
    private void Update()
    {
        if (SoundManager.Lose)
        {
            if (!YouAlreadyPlay)
            {
                sourse.PlayOneShot(gameOver);
                YouAlreadyPlay = true;
            }
        }
    }
}

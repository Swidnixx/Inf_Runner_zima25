using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public AudioClip[] musics;

    public AudioClip click;
    public AudioClip jump;
    public AudioClip coin;

    AudioSource audioSource;

    int music_num = 0;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musics[0];
        audioSource.Play();
    }

    private void Update()
    {
        if(!audioSource.isPlaying)
        {
            music_num++;
            music_num %= musics.Length;
            audioSource.clip = musics[music_num];
            audioSource.Play();
        }
    }

    public void PlayClick()
    {
        audioSource.PlayOneShot(click);
    }

    public void PlayJump()
    {
        audioSource.PlayOneShot(jump);
    }

    internal void PlayCoin()
    {
        audioSource.PlayOneShot(coin);
    }
}

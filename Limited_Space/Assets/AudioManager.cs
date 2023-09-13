using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]AudioSource audioSource;
    [SerializeField] AudioSource musicAudioSource;

    [SerializeField] AudioClip clip;
    public void PlayAudio(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    void Update()
    {
        SelectMusic(clip);
    }

    public void SelectMusic(AudioClip audioClip)
    {
        musicAudioSource.clip = audioClip;
        musicAudioSource.Play();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]AudioSource audioSource;


    public void PlayAudio(AudioClip audioClip)
    {
       audioSource.clip = audioClip;
        audioSource.Play();
    }
}

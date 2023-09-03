using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Collect;
    public AudioClip Jump;
    public AudioClip Death;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void jumpSound()
    {
        audioSource.PlayOneShot(Jump, 0.2F);
    }
    public void collectSound()
    {
        audioSource.PlayOneShot(Collect, 0.5F);
    }
    public void deathSound()
    {
        audioSource.PlayOneShot(Death, 1F);
    }
}

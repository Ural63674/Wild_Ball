using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager snd;
    private AudioSource audioSrc;
    private AudioClip[] sparksSound;
    private int randomSound;

    private void Start()
    {
        snd = this;
        audioSrc = GetComponent<AudioSource>();
        sparksSound = Resources.LoadAll<AudioClip>("SparksSound");
    }

    public void PlaySparksSound() 
    {
        randomSound = Random.Range(0, 5);
        audioSrc.PlayOneShot(sparksSound[randomSound]);
    }
}

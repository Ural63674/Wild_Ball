using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparksSound : MonoBehaviour
{
    
    public ParticleSystem sparks;
    private void Start()
    {
        sparks = GetComponent<ParticleSystem>();
    }

    private void OnParticleCollision(GameObject other)
    {
        
        if (other.name == "SparksSound")
        {
            SoundManager.snd.PlaySparksSound();
        }
    }    
}

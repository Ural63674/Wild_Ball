using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift1AnimationWork : MonoBehaviour
{
    public bool animationReproduced = false;
    public void AnimationReproducedOn()
    {
        animationReproduced = true;
    }

    public void AnimationReproducedOff()
    {
        animationReproduced = false;
    }
}

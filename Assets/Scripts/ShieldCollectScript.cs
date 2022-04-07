using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollectScript : MonoBehaviour
{
    public bool isShieldTaken;
    public GameObject playerCrystalEffect;
    public Animator shieldAnimator;
    public GameObject shieldCrystalEffect;
    public GameObject shieldPanel;
    public GameObject shieldCoinEffect;
    public GameObject shield;
    public AudioSource shieldCollectAudio;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            shieldCoinEffect.SetActive(true);            
            shieldAnimator = GetComponent<Animator>();
            shieldAnimator.SetTrigger("shieldRaise");

            shieldCrystalEffect.SetActive(false);
            
            shieldPanel.SetActive(true);            
            isShieldTaken = true;
            playerCrystalEffect.SetActive(true);
            shield.SetActive(false);

            shieldCollectAudio.Play();
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinEffectTrigger : MonoBehaviour
{
    public GameObject coinEffect;  
    public GameObject coin;
    public Animator coinRaise;
    public CoinCollectScript coinCollect;
    public AudioSource coinCollectAudio;
   
    void Start() 
    {
        coinCollect.coinsCollect = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            coinEffect.SetActive(true);            
            coinRaise.GetComponent<Animator>();
            coinRaise.SetTrigger("CoinRaise");
            coinCollect.coinsCollect++;
            coin.SetActive(false);
            coinCollectAudio.Play();
        }
    }    
}

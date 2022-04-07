using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject levelCompletePanel;
    public Animation player;
    public GameObject portalEnterParticle;
    public Rigidbody playerBall;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {           
            player.GetComponent<Animation>().Play("PortalEnter");            
            playerBall = playerBall.GetComponent<Rigidbody>();
            playerBall.isKinematic = true;
            //Time.timeScale = 0;
            StartCoroutine(PortalParticleActivate());
            StartCoroutine(EndGame());
        }
    }
    private IEnumerator EndGame() 
    {        
        yield return new WaitForSeconds(3);
        levelCompletePanel.SetActive(true);
    }
    private IEnumerator PortalParticleActivate() 
    {
        yield return new WaitForSeconds(2);
        portalEnterParticle.transform.position = playerBall.position;
        playerBall.GetComponent<MeshRenderer>().enabled = false;
        portalEnterParticle.SetActive(true);       
    }
}

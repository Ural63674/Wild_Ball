using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDead : MonoBehaviour
{
    public GameObject defeatePanel;
    public GameObject playerBall;
    public GameObject playerDead;
    public GameObject player;
    public ShieldCollectScript isShieldTaken;
    public ShieldActiveTimer isShieldLost;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && isShieldTaken.isShieldTaken == false || other.tag == "Player" && isShieldLost.isShieldLost == true)
        {
            player.transform.position = playerBall.transform.position;
            playerDead.SetActive(true);
            playerBall.SetActive(false);
            StartCoroutine(timerToDeath());
        }
    }

    private IEnumerator timerToDeath()
    {
        yield return new WaitForSeconds(3);

        defeatePanel.SetActive(true);
    }
}

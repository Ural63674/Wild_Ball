using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadTriggerScript : MonoBehaviour
{
    public GameObject defeatePanel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "PlayerBall") 
        {
            defeatePanel.SetActive(true);
        }
    }
}

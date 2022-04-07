using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift2LaunchScript : MonoBehaviour
{
    public GameObject ePanelButton;
    public Animation lift2;
    private bool objectIn;
    public Lift2AnimationWork animationReproduced;

    private void Update()
    {
        if (objectIn && Input.GetKeyDown(KeyCode.E) == true && animationReproduced.animationReproduced == false)
        {
            lift2.GetComponent<Animation>().Play("Lift 2");
            ePanelButton.SetActive(false);
            objectIn = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {        
        ePanelButton.SetActive(true);
        objectIn = true;       
    }

    private void OnTriggerExit(Collider other)
    {        
        ePanelButton.SetActive(false);
        objectIn = false;       
    }
}

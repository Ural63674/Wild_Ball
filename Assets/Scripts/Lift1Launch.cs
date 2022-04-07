using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift1Launch : MonoBehaviour
{
    public GameObject ePanelButton;
    public Animation lift1;
    private bool objectIn;
    public Lift1AnimationWork animationReproduced;

    private void Update()
    {
        if (objectIn && Input.GetKeyDown(KeyCode.E) == true && animationReproduced.animationReproduced == false)
        {
            lift1.GetComponent<Animation>().Play("Lift 1");
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFoundationLift3 : MonoBehaviour
{
    public Animation lift3;
    private bool buttonCoolDown = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Button" && buttonCoolDown == false) 
        {
            Debug.Log("Лифт запущен");
            lift3.GetComponent<Animation>().Play("Lift 3");
            buttonCoolDown = true;
            CoolDown();
        }
    }
    private IEnumerator CoolDown() 
    {
        yield return new WaitForSeconds(4);
        buttonCoolDown = false;
    }
}

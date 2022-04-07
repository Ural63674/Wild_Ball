using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPlatform : MonoBehaviour
{
    public GameObject springPlatform;
    [SerializeField] float springPower;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") 
        {
            springPlatform.GetComponent<Rigidbody>().AddForce(Vector3.up * springPower, ForceMode.Impulse);
        }
    }
}

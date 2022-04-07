using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelPlayerEffect : MonoBehaviour
{       
    public Animation playerStart;
    public MeshRenderer playerBall;

    // Start is called before the first frame update
    void Awake()
    {
        
        StartCoroutine(StartLevelPlayer());
        Debug.Log("Старт уровня 2");       
    }
   
    private IEnumerator StartLevelPlayer()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Старт корутины");

        playerBall.GetComponent<MeshRenderer>().enabled = true;
        playerStart.GetComponent<Animation>().Play("StartLevelPlayer");
    }
}

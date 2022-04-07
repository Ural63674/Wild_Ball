using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldActiveTimer : MonoBehaviour
{
    public ShieldCollectScript isShieldTaken;
    public Text shieldTimerSecondsText;
    private float shieldTimerSeconds;
    public Text shieldTimerMinutesText;
    private float shieldTimerMinutes;
    public bool isShieldLost;

    public GameObject playerCrystalEffect;
    public GameObject shieldPanel;


    private void Start()
    {
        shieldTimerMinutes = 01;
        shieldTimerSeconds = 00;
    }
    void Update()
    {
        if (isShieldTaken == true) 
        {                      
            shieldTimerSeconds -= Time.deltaTime;

            if (shieldTimerMinutes > 0 && shieldTimerSeconds <= 0) 
            {
                shieldTimerMinutes -= 1;
                shieldTimerSeconds = 59;
            }
            else if (shieldTimerMinutes <= 0 && shieldTimerSeconds <= 0) 
            {
                shieldTimerMinutes = 00;
                shieldTimerSeconds = 00;
                isShieldLost = true;
                playerCrystalEffect.SetActive(false);
                shieldPanel.SetActive(false);
            }

            shieldTimerMinutesText.text = shieldTimerMinutes.ToString();
            shieldTimerSecondsText.text = (Mathf.Round(shieldTimerSeconds)).ToString();
        }
    }
}

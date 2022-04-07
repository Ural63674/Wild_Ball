using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WildBall.Inputs
{
    public class JumpingScript : MonoBehaviour
    {
        public Image jumpingScaleImage;
        public PlayerInput isJumpingActive;
        private float currentTime;
        private float jumpDelayTime;
        public GameObject jumpingPanel;

        void Start()
        {
            jumpingScaleImage = GetComponent<Image>();
            jumpingScaleImage.fillAmount = 0;
            currentTime = 0;
            jumpDelayTime = 1;
        }


        void Update()
        {
            if (isJumpingActive.isJumpActive == false) 
            {
                currentTime += Time.deltaTime;

                if (currentTime < jumpDelayTime) 
                {                    
                    jumpingScaleImage.fillAmount = currentTime / jumpDelayTime;
                }
                else
                {
                    
                    currentTime = 0;
                    jumpingScaleImage.fillAmount = 0;
                }                    
            }
        }
    }
}

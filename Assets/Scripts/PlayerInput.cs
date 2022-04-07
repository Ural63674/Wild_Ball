using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        public CameraRotateAround cameraPosition;
        private Vector3 movement;
        private Vector3 jump;

        public Transform player;
        public Transform mainCamera;

        private Vector3 movementW;
        private Vector3 movementS;
        private Vector3 movementA;
        private Vector3 movementD;
        
        public bool isJumpActive = true;

        private PlayerMovement PlayerMovement;
        public GameObject jumpingPanel;

        private void Awake()
        {
            PlayerMovement = GetComponent<PlayerMovement>();
        }


        private void Update()
        {
            
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            Vector3 cameraOrientation = new Vector3(player.position.x - mainCamera.position.x, 0, player.position.z - mainCamera.position.z);
            Vector3 cameraOrientNormal = cameraOrientation.normalized;

            if (Input.GetKeyDown("w")) movementW = new Vector3(cameraOrientNormal.x, 0, cameraOrientNormal.z);
            else if (Input.GetKeyUp("w")) movementW = new Vector3(0,0,0);

            if (Input.GetKeyDown("s")) movementS = new Vector3(-cameraOrientNormal.x, 0, -cameraOrientNormal.z);
            else if(Input.GetKeyUp("s")) movementS = new Vector3(0, 0, 0);

            if (Input.GetKeyDown("a")) 
            {                
                    movementA = new Vector3(-cameraOrientNormal.z, 0, cameraOrientNormal.x);                 
            }
            else if (Input.GetKeyUp("a")) movementA = new Vector3(0, 0, 0);

            if (Input.GetKeyDown("d"))
            {                
                    movementD = new Vector3(cameraOrientNormal.z, 0, -cameraOrientNormal.x);                
            }
            else if (Input.GetKeyUp("d")) movementD = new Vector3(0, 0, 0);


            movement = new Vector3(movementW.x + movementS.x + movementA.x + movementD.x,
                                   0,
                                   movementW.z + movementS.z + movementA.z + movementD.z);            

            if (Input.GetButtonDown(GlobalStringVars.JUMP_BUTTON))
            {
                if (isJumpActive)
                {
                    jump = new Vector3(0, 10, 0);
                    PlayerMovement.JumpCharacter(jump);
                    isJumpActive = false;
                    StartCoroutine(Jumping());
                }
            }           
        }

        private void FixedUpdate()
        {
            PlayerMovement.MoveCharacter(movement);
        }       

        public IEnumerator Jumping() 
        {
            jumpingPanel.SetActive(true);
            yield return new WaitForSeconds(1);
            isJumpActive = true;
            jumpingPanel.SetActive(false);

        }
    }
}

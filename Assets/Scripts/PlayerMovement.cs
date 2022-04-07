using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody playerRigidbody;
        [SerializeField, Range(0, 10)] private float speed;
        [SerializeField] private float jumpPower;
        

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);    
        }

        public void JumpCharacter(Vector3 jump) 
        {
            playerRigidbody.AddForce(jump * jumpPower);
        }

        public float Speed()
        {
            return speed;
        }
    }
}

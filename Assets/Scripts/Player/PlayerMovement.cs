using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        #region Public
        
        
        
        #endregion
        #region Private

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            _isGrounded = _characterController.isGrounded;

            Movement();
            FakeGravity();
        }

        private void Movement()
        {
            Vector3 newPos = transform.right * playerController.UserInput().x +
                             transform.forward * playerController.UserInput().y;

            if (playerController.Sprint())
            {
                _characterController.Move( newPos * sprintForce * Time.deltaTime);
                return;
            }
            _characterController.Move( newPos * movementForce * Time.deltaTime);
        }

        private void FakeGravity()
        {
            if (_isGrounded && _velocity.y < 0) _velocity.y = -2;
            
            Jump();
            
            _velocity.y += fakeGravity * Time.deltaTime;
            _characterController.Move(_velocity * Time.deltaTime);
        }

        private void Jump()
        {
            if (!_isGrounded) return;
            
            if (playerController.Jump())
                _velocity.y = Mathf.Sqrt((jumpForce * -2f * fakeGravity));
        }
        
        [SerializeField] private PlayerController playerController;
        [SerializeField] private float fakeGravity;
        [SerializeField] private float movementForce;
        [SerializeField] private float sprintForce;
        [SerializeField] private float jumpForce;
        
        private CharacterController _characterController;
        private bool _isGrounded;
        private Vector3 _velocity;

        #endregion
    }
}

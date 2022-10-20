using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerCamera : MonoBehaviour
    {
        #region Public
        
        
        
        #endregion
        #region Private

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            _xRotation -= PlayerController.UserMouseInput().y;
            _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
            
            transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
            playerBody.Rotate(Vector3.up * PlayerController.UserMouseInput().x);
        }

        [SerializeField] private float sensibility;
        [SerializeField] private Transform playerBody;

        private float _xRotation = 0f;

        #endregion
    }
}

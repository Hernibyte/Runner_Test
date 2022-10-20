using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [Serializable]
    public class PlayerController
    {
        #region Public
        
        /// <summary>
        /// Get user input.
        /// </summary>
        /// <returns>Movement user input values</returns>
        public Vector2 UserInput()
        {
            var x = Input.GetAxis(horizontalAxis);
            var y = Input.GetAxis(verticalAxis);
            
            return new Vector2(x, y);
        }

        /// <summary>
        /// Get if the user hold sprint key
        /// </summary>
        /// <returns></returns>
        public bool Sprint()
        {
            return Input.GetKey(sprintKey) ? true : false;
        }

        /// <summary>
        /// Get if the user press jump key
        /// </summary>
        /// <returns></returns>
        public bool Jump()
        {
            return Input.GetKeyDown(jumpKey) ? true : false;
        }
        
        #endregion
        #region Private

        [SerializeField] private string horizontalAxis;
        [SerializeField] private string verticalAxis;
        [SerializeField] private KeyCode sprintKey;
        [SerializeField] private KeyCode jumpKey;

        #endregion
    }
}

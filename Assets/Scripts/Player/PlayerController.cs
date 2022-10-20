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
        public static Vector2 UserInput()
        {
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");
            
            return new Vector2(x, y);
        }

        /// <summary>
        /// Get if the user hold sprint key
        /// </summary>
        /// <returns></returns>
        public static bool Sprint()
        {
            return Input.GetKey(KeyCode.LeftShift) ? true : false;
        }

        /// <summary>
        /// Get if the user press jump key
        /// </summary>
        /// <returns></returns>
        public static bool Jump()
        {
            return Input.GetKeyDown(KeyCode.Space) ? true : false;
        }

        public static Vector2 UserMouseInput()
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            
            return new Vector2(x, y);
        }
        
        #endregion
        #region Private

        //[SerializeField] private string horizontalAxis;
        //[SerializeField] private string verticalAxis;
        //[SerializeField] private KeyCode sprintKey;
        //[SerializeField] private KeyCode jumpKey;

        #endregion
    }
}

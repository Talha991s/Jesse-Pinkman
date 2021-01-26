using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Character
{
    public class MovementComponent : MonoBehaviour
    {
        public void OnMovement(InputValue value)
        {
            Debug.Log(value.Get<Vector2>());
        }    
    }

}

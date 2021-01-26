using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Character
{
   
    public class MovementComponent : MonoBehaviour
    {
        [SerializeField] private float WalkSpeed;
        [SerializeField] private float RunSpeed;
        [SerializeField] private float JumpForce;

        //component
        private PlayerController PlayerController;
        private Vector2 InputVector = Vector2.zero;

       //   private GameInputActions inputActions;

        private void Awake()
        {
            PlayerController = GetComponent<PlayerController>();
        }

        private void Start()
        {
            Debug.Log("Start");
            
        }
        private void Update()
        {
            if (!(InputVector.magnitude > 0)) return;
            if (PlayerController.isJumping) return;

            Vector3 moveDirection = transform.forward * InputVector.y + transform.right * InputVector.x;
            
            float currentSpeed = PlayerController.isRunning ? RunSpeed : WalkSpeed;

            Vector3 movementDirection = moveDirection * (currentSpeed * Time.deltaTime);

            transform.position += movementDirection;
        }

        public void OnMovement(InputValue value)
        {
            InputVector = value.Get<Vector2>();
            //Debug.Log(value.Get());
        }

    }

}

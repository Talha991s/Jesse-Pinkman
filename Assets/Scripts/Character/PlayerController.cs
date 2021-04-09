using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character.UI;

namespace Character
{
    
    public class PlayerController : MonoBehaviour
    {
        public Crosshair Crosshair => crosshairComponent;
        [SerializeField] private Crosshair crosshairComponent;

        public bool IsFiring;
        public bool IsReloading;
        public bool IsJumping;
        public bool IsRunning;
        public bool IsPaused;
        public bool IsResume;
        public bool IsBackToMainMenu;
        public bool IsInventoryOpen;
    }

    
}

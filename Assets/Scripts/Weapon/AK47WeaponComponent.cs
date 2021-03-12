using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Weapon;

namespace Weapon
{
    public class AK47WeaponComponent : WeaponComponent
    {
        private Camera ViewCamera;
        private RaycastHit HitLocation;

        private void Awake()
        {
            ViewCamera = Camera.main;
        }

        protected override void FireWeapon()
        {
            Debug.Log("FiringWEAPON"); 

            if(WeaponStats.BulletInClip >0 && !Reloading && !WeaponHolder.Controller.IsJumping)
            {
                base.FireWeapon();
                Ray screenRay = ViewCamera.ScreenPointToRay(new Vector3(Crosshair.CurrentAimPosition.x,
                    Crosshair.CurrentAimPosition.y, 0.0f));

                if (Physics.Raycast(screenRay, out RaycastHit hit, WeaponStats.FireDistance,
                    WeaponStats.WeaponHitLayer)) //return;
                {
                    Vector3 RayDirection = HitLocation.point - ViewCamera.transform.position;

                    Debug.DrawRay(ViewCamera.transform.position, RayDirection * WeaponStats.FireDistance, Color.red);

                    HitLocation = hit;
                }
                
            }
            else if (WeaponStats.BulletInClip <= 0)
            {
                WeaponHolder.StopReloading();
            }
        }

        private void OnDrawGizmos()
        {
            if(HitLocation.transform)
            {
                Gizmos.DrawSphere(HitLocation.point, 0.2f);
            }
           
        }
    }
}



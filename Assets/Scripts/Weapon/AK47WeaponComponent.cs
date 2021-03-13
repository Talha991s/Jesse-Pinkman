using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Weapon;

namespace Weapon
{
    public class AK47WeaponComponent : WeaponComponent
    {
        private int damage = 1;
        private Camera ViewCamera;
        private RaycastHit HitLocation;
        [SerializeField]
        private ParticleSystem shotparticle;
        [SerializeField]
        private AudioSource ShootingSound;



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
                shotparticle.Play();
                ShootingSound.Play();
                Ray screenRay = ViewCamera.ScreenPointToRay(new Vector3(Crosshair.CurrentAimPosition.x,
                    Crosshair.CurrentAimPosition.y, 0.0f));

                if (Physics.Raycast(screenRay, out RaycastHit hit, WeaponStats.FireDistance,
                    WeaponStats.WeaponHitLayer)) //return;
                {
                    Vector3 RayDirection = HitLocation.point - ViewCamera.transform.position;

                    Debug.DrawRay(ViewCamera.transform.position, RayDirection * WeaponStats.FireDistance, Color.red);

                    HitLocation = hit;

                    var health = HitLocation.collider.GetComponent<Heath>(); // destroy object on hit.
                    if(health !=null)
                    {
                        health.TakeDamage(damage);
                    }
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



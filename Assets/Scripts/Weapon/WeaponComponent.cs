using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
using Weapon;
using Character.UI;
using System;

namespace Weapon
{

    public enum WeaponType
    {
        None,
        MachineGun,
        Pistol
    }

    [Serializable]
    public struct WeaponStats
    {
        public WeaponType WeaponType;
        public string Name;
        public float Damage;
        public int BulletInClip;
        public int ClipSize;
        public int TotalBulletAvailable;

        public float FireStartsDelay;
        public float FireRate;
        public float FireDistance;
        public bool Repeating;

        public LayerMask WeaponHitLayer;
    }
    public class WeaponComponent : MonoBehaviour
    {
        //public Transform handposition;

  
        public Transform GripLocation => GripIKLocation;
        [SerializeField] private Transform GripIKLocation;

        public bool Firing { get; private set; }
        public bool Reloading { get; private set; }

       public WeaponStats WeaponStats;

        protected WeaponHolder WeaponHolder;
        protected Crosshair Crosshair;

        public void Initialize(WeaponHolder weaponHolder, Crosshair crosshair)
        {
            WeaponHolder = weaponHolder;
            Crosshair = crosshair;
        }
        public virtual void StartFiring()
        {
            Firing = true;
            if (WeaponStats.Repeating)
            {
                InvokeRepeating(nameof(FireWeapon), WeaponStats.FireStartsDelay, WeaponStats.FireRate);
            }
            else
            {
                FireWeapon();
            }
        }
        public virtual void StopFiring()
        {
            Firing = false;
            CancelInvoke(nameof(FireWeapon));
        }
        protected virtual void FireWeapon()
        {
            WeaponStats.BulletInClip--;
        }
        public void StartReloading()
        {
            Reloading = true;
           
            ReloadWeapon();
        }

        public void StopReloading()
        {
            Reloading = false;
        }
        protected virtual void ReloadWeapon()
        {
            int bulletRoReload = WeaponStats.ClipSize - WeaponStats.TotalBulletAvailable;
            if(bulletRoReload <0)
            {
               
                Debug.Log("OUT OF AMMO");
                WeaponStats.BulletInClip  = WeaponStats.ClipSize;
                WeaponStats.TotalBulletAvailable -= WeaponStats.ClipSize;
            }
            else
            {
                
                Debug.Log("Reload");
                WeaponStats.BulletInClip = WeaponStats.TotalBulletAvailable;
                WeaponStats.TotalBulletAvailable =0;
            }
        }
    }
}

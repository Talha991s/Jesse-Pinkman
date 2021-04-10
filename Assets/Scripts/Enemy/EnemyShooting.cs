using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyShooting : MonoBehaviour
{
    private Detection detect;
    private Heath healthTarget;
    private float attackTimer;
    public ParticleSystem shootingeffect;
    //public Animator shootanim;
    public AudioSource shotgun;

    

    [SerializeField]
    private float attackRefreshRate =1.5f;
    private void Awake()
    {
        detect = GetComponent<Detection>();
        detect.OnDetect += Detection_OnDetect;
    }

    private void Detection_OnDetect(Transform target)
    {
        Heath health = target.GetComponent<Heath>();
        if(health != null)
        {
            healthTarget = health;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(healthTarget != null)
        {
            attackTimer += Time.deltaTime;

            if(CanAttack())
            {
                Attack();
            }
        }

    }

    private bool CanAttack()
    {
        return attackTimer >= attackRefreshRate;
    }
    private void Attack()
    {
        //shootanim.SetBool("Shooting", true);
        shootingeffect.Play();
        shotgun.Play();
        attackTimer = 0;
        healthTarget.TakeDamage(5);
        if (healthTarget.CurrentHealth <= 0)
        {
           // P_dyingsound.Play();
            shootingeffect.Stop();
            shotgun.Stop();
            attackTimer = 1;
            //StartCoroutine("playsound");
            // StartCoroutine(playsound());
            //playsound();
        }
    }


}

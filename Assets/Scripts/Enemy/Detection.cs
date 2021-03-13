using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
using Character;
public class Detection : MonoBehaviour
{
    public event System.Action<Transform> OnDetect = delegate { };

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerController>();
        if(player != null)
        {
            OnDetect(player.transform);
            Debug.Log("Aggrod");
        }
    }
}

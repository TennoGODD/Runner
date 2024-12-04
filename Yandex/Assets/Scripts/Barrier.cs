using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifaier playerModifaier = other.attachedRigidbody.GetComponent<PlayerModifaier>();
        if(playerModifaier != null )
        {
            playerModifaier.HitBarrier();
            Destroy(gameObject);
        }
    }
}

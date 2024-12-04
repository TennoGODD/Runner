using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour PlayerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if(PlayerBehaviour != null )
        {
            PlayerBehaviour.StartPreFinishBehaviour();
        }
    }
}

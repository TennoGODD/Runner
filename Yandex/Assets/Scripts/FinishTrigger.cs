using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour PlayerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if (PlayerBehaviour != null)
        {
            PlayerBehaviour.StartFinishBehaviour();
            FindAnyObjectByType<GameManager>().ShowFinishWindow();
        }
    }
}

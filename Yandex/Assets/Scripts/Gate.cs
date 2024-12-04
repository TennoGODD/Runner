using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] deformationType _deformationType;
    [SerializeField] int _value;
    [SerializeField] GateApperance _gateApperance;
    private void OnValidate() {
        _gateApperance.UpdateVisual(_deformationType,_value);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifaier playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifaier>();
        if (playerModifaer != null)
        {
            if(_deformationType == deformationType.Hight)
            {
                playerModifaer.AddHeight(_value);
            }
            else if(_deformationType == deformationType.Width)
            {
                playerModifaer.AddWidth(_value);
            }
            Destroy(gameObject);
        }
    }
}

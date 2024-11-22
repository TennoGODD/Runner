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
}

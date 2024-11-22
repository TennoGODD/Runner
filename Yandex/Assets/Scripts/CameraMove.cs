using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _transformPlayer;
    void LateUpdate()
    {
        transform.position = _transformPlayer.position ;
    }
}

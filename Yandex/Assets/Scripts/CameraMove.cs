using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _transformPlayer;

    private void Start()
    {
        transform.parent = null;
    }
    void LateUpdate()
    {
        if(_transformPlayer != null )
        {
            transform.position = _transformPlayer.position;
        }
    }
}

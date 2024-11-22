using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speedMove = 3f;
    [SerializeField] Animator _animator;
    private float oldMousePositionX;
    private float eulerY;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            oldMousePositionX = Input.mousePosition.x;
            _animator.SetBool("Run",true);
        }
        if(Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * speedMove;
            newPosition.x = Mathf.Clamp(newPosition.x,-2.5f,2.5f);
            transform.position = newPosition;

            float deltaX = Input.mousePosition.x  - oldMousePositionX;
            oldMousePositionX = Input.mousePosition.x;

            eulerY += deltaX;
            eulerY = Mathf.Clamp(eulerY,-70f,70f);
            transform.eulerAngles = new Vector3(0,eulerY,0);
        }
        if (Input.GetMouseButtonUp(0))
            _animator.SetBool("Run",false);
    }
}

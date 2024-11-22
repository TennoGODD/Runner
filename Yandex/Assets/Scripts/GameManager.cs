using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _gameObject;
    public void Play()
    {
        _gameObject.SetActive(false);
    }   
}

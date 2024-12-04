using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifaier : MonoBehaviour
{
    [SerializeField] int _width;
    [SerializeField] int _height;

    float _widthMulti = 0.0005f;
    float _heightMulti = 0.01f;

    [SerializeField] Renderer _render;
    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;

    [SerializeField] Transform _colliderTransform;

    private void Start()
    {
        SetHeight(Progress.Instance.height);
        SetWidth(Progress.Instance.Width);
    }

    private void Update()
    {
        float offsetY = _height * _heightMulti + 0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
        _colliderTransform.localScale = new Vector3(1,1.84f + _height * _heightMulti,1);

        if(Input.GetKeyDown(KeyCode.W))
        {
            AddWidth(20);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            AddHeight(20);
        }
    }

    public void AddWidth(int value)
    {
        _width += value;
        UpdateWidth();
    }

    public void AddHeight(int value) 
    {
        _height += value;
    }

    public void SetWidth(int value)
    {
        _width = value;
        UpdateWidth();
    }

    public void SetHeight(int value)
    {
        _height = value;
    }

    public void HitBarrier()
    {
        if(_height > 0)
        {
            _height -= 50;
        }
        else if( _width > 0)
        {
            _width -= 50;
            UpdateWidth();
        }
        else
        {
            Die();
        }
    }
    private void UpdateWidth()
    {
        _render.material.SetFloat("_PushValue", _width * _widthMulti);
    }
    private void Die()
    {
        FindAnyObjectByType<GameManager>().ShowFinishWindow();
        Destroy(gameObject);
    }
}

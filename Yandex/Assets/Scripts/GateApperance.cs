using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum deformationType{
    Hight,
    Width
}

public class GateApperance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] Image _topImage;
    [SerializeField] Image _glassImage;

    [SerializeField] Color _colorPositiv;
    [SerializeField] Color _colorNegative;

    [SerializeField] int value;

    [SerializeField] deformationType _deformationType;
    [SerializeField] GameObject _epandLable;
    [SerializeField] GameObject _shrinkLable;
    [SerializeField] GameObject _upLable;
    [SerializeField] GameObject _downLabe;

    public void UpdateVisual(deformationType _deformationType, int value) 
    {
        string prefix = "";

        if(value > 0)
        {
            prefix = "+";
            SetColor(_colorPositiv);
        }
        else if(value == 0)
        {
            SetColor(Color.grey);
        }
        else 
        {
            SetColor(_colorNegative);
        }

        _text.text = prefix + value.ToString();

        _epandLable.SetActive(false);
        _shrinkLable.SetActive(false);
        _upLable.SetActive(false);
        _downLabe.SetActive(false);

        if(_deformationType == deformationType.Width)
        {
            if (value > 0)
            {
                _epandLable.SetActive(true);
            }
            else
            {
                _shrinkLable.SetActive(true);
            }
        }
        else if(_deformationType == deformationType.Hight)
        {
            if (value > 0)
            {
                _upLable.SetActive(true);
            }
            else
            {
                _downLabe.SetActive(true);
            }
        }
    }

    void SetColor(Color color)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r,color.g,color.b,0.5f);
    }
}

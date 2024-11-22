using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int numberOfCoins;
    [SerializeField] TextMeshProUGUI _text;

    public void addOne()
    {
        numberOfCoins += 1;
        _text.text = numberOfCoins.ToString();
    }
}


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int numberOfCoins;
    [SerializeField] TextMeshProUGUI _text;

    private void Start()
    {
        numberOfCoins = Progress.Instance.Coins;
        _text.text = numberOfCoins.ToString();
    }
    public void addOne()
    {
        numberOfCoins += 1;
        _text.text = numberOfCoins.ToString();
    }
    public void SaveToProgress()
    {
        Progress.Instance.Coins = numberOfCoins;
    }

    public void SpendMoney(int value)
    {
        numberOfCoins -= value;
        _text.text = numberOfCoins.ToString();
    }
}


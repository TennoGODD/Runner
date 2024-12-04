using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager _coinManager;
    PlayerModifaier _playerModifaier;

    private void Start()
    {
        _playerModifaier = FindAnyObjectByType<PlayerModifaier>();
    }

    public void BuyWidth()
    {
        if(_coinManager.numberOfCoins >= 20)
        {
            _coinManager.SpendMoney(20);
            Progress.Instance.Coins = _coinManager.numberOfCoins;
            Progress.Instance.Width += 25;
            _playerModifaier.SetWidth(Progress.Instance.Width);
        }
    }

    public void BuyHeight()
    {
        if (_coinManager.numberOfCoins >= 20)
        {
            _coinManager.SpendMoney(20);
            Progress.Instance.Coins = _coinManager.numberOfCoins;
            Progress.Instance.height += 25;
            _playerModifaier.SetHeight(Progress.Instance.height);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPController : MonoBehaviour
{
    private GameController _gameController;
    private MoneyController _moneyController;
    private NoAdsUI _noAdsUI;
    private void Awake()
    {
        _gameController = GameController.Instance;
        _moneyController = _gameController.MoneyController;
        _noAdsUI = _gameController.UIMenu.NoAdsUI;
    }

    public void MakePurchase(IAPProduct product)
    {
        switch (product)
        {
            case IAPProduct.Coin100:
                _moneyController.AddMoney(100);
                break;
            case IAPProduct.Coin500:
                _moneyController.AddMoney(500);
                break;
            case IAPProduct.NoADS:
                _noAdsUI.SetBuy();
                break;
            default:
                Debug.LogError("Unknown product!");
                break;
        }
    }
}

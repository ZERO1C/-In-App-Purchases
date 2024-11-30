using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class MoneyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;

    private MoneyController _moneyController;

    private void Awake()
    {
        _moneyController = GameController.Instance.MoneyController;
        ChangeMoney(_moneyController.Money);
        _moneyController.OnMoneyChanged += ChangeMoney;
    }

    public void ChangeMoney(int money) => _moneyText.text = money.ToString();
    private void OnDestroy() => _moneyController.OnMoneyChanged -= ChangeMoney;
}
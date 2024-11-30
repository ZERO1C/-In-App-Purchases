using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    private int _money;
    private readonly string _moneyKey = "Money";
    public event Action<int> OnMoneyChanged;
    public int Money => _money;
    
    private void Awake() => LoadMoney();

    public void LoadMoney()
    {
        _money = PlayerPrefs.GetInt(_moneyKey, 0);
        OnMoneyChanged?.Invoke(_money);
    }

    public void AddMoney(int amount)
    {
        _money += amount;
        OnMoneyChanged?.Invoke(_money);
        PlayerPrefs.SetInt(_moneyKey, _money);
    }

    public void RemoveMoney(int amount)
    {
        _money -= amount;
        OnMoneyChanged?.Invoke(_money);
        PlayerPrefs.SetInt(_moneyKey, _money);
    }
}
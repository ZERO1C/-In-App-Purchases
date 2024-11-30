using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class GameController : MonoSingleton<GameController>
{
    [field: SerializeField] public IAPController IAPController { get; set; }
    [field: SerializeField] public MoneyController MoneyController { get; set; }
    [field: SerializeField] public UIMenu UIMenu { get; set; }
}
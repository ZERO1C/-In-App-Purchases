using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoAdsUI : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _colorBuy;

    public void SetBuy() => _image.color = _colorBuy;
}
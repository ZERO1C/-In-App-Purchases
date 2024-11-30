using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.UI;

public class IAPBuyButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private CodelessIAPButton _iapButton;
    private IAPController _iapController;
    private Product _product;

    private void Awake()
    {
        _iapController = GameController.Instance.IAPController;

        if (_iapButton == null)
        {
            Debug.LogError("Компонент CodelessIAPButton відсутній на цьому GameObject!");
            return;
        }

        _product = CodelessIAPStoreListener.Instance.GetProduct(_iapButton.productId);
        _iapButton.onPurchaseComplete.AddListener(HandlePurchaseComplete);
        _iapButton.onPurchaseFailed.AddListener(HandlePurchaseFailed);

        CheckProductStatus(_product);
    }

    private void OnDestroy()
    {
        if (_iapButton == null) return;

        _iapButton.onPurchaseComplete.RemoveListener(HandlePurchaseComplete);
        _iapButton.onPurchaseFailed.RemoveListener(HandlePurchaseFailed);
    }

    private void HandlePurchaseComplete(Product product)
    {
        Debug.Log($"Покупка успішна: {product.definition.id}");
        _iapController.MakePurchase(ConvertToEnum(product.definition.id));
        SaveBuy(product);
    }

    private void HandlePurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
    {
        Debug.LogError($"Покупка не вдалася: {product.definition.id}, Причина: {failureDescription.reason}");
    }

    public void SaveBuy(Product product)
    {
        if (product.definition.type == ProductType.NonConsumable)
        {
            PlayerPrefs.SetInt(product.definition.id, 1);
            SetButtonInactive();
        }
    }
    private void CheckProductStatus(Product product)
    {
        if (product.definition.type == ProductType.NonConsumable &&
            PlayerPrefs.GetInt(product.definition.id, 0) == 1)
        {
            _iapController.MakePurchase(ConvertToEnum(product.definition.id));
            SetButtonInactive();
        }
    }
    

    private void SetButtonInactive()
    {
        _button.interactable = false;
    }
    
    private IAPProduct ConvertToEnum(string productId)
    {
        if (System.Enum.TryParse(productId, true, out IAPProduct result))
            return result;
        return IAPProduct.Unknown;
    }
}
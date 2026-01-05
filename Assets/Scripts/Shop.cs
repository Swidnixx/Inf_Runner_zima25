using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] PowerupManager powerupManager;

    [SerializeField] TMP_Text moneyText;
    [SerializeField] TMP_Text magnetInfo;

    int money;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Coins");
        DisplayUI();
    }

    public void UpgradeMagnet()
    {
        SoundManager.Instance.PlayClick();
        if (powerupManager.Magnet.CanUpgrade)
        {
            if (money > powerupManager.Magnet.Price)
            {
                money -= powerupManager.Magnet.Price;
                PlayerPrefs.SetInt("Coins", money);
                powerupManager.Magnet = powerupManager.Magnet.Upgrade;
                DisplayUI();
            }
        }
    }

    void DisplayUI()
    {
        moneyText.text = money.ToString();
        int magnetLvl = powerupManager.Magnet.Level;
        int magnetPrice = powerupManager.Magnet.Price;
        magnetInfo.text = $"{magnetLvl}: ${magnetPrice}";
    }
}

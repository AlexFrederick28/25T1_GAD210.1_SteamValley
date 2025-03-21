using TMPro;
using UnityEngine;

public class PermanentUpgrade : MonoBehaviour
{
    public int healthCost;
    public int damageCost;
    public int speedCost;

    public int healthUpgrade;
    public int damageUpgrade;
    public float speedUpgrade;

    public TextMeshProUGUI healthCostUI;
    public TextMeshProUGUI damageCostUI;
    public TextMeshProUGUI speedCostUI;

    private void Update()
    {

        UpdateUpgradeValue();
        UpdateUI();
        
    }

    private void UpdateUI()
    {
        healthCostUI.text = "COST: " + healthCost;
        damageCostUI.text = "COST: " + damageCost;
        speedCostUI.text = "COST: " + speedCost;
    }

    private void UpdateUpgradeValue()
    {
        healthUpgrade = healthCost / 2;
        damageUpgrade = damageCost / 2;
        speedUpgrade = 0.025f * speedCost;
    }
}

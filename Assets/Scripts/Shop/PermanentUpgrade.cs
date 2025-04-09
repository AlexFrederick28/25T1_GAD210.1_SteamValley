using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PermanentUpgrade : MonoBehaviour
{

    [SerializeField] private PlayerStats _PlayerStats;

    public int healthCost;
    public int damageCost;
    public int speedCost;

    public int healthUpgrade;
    public int damageUpgrade;
    public float speedUpgrade;

    public TextMeshProUGUI healthCostUI;
    public TextMeshProUGUI damageCostUI;
    public TextMeshProUGUI speedCostUI;

    public TextMeshProUGUI healthStat;
    public TextMeshProUGUI damageStat;
    public TextMeshProUGUI speedStat;
    public TextMeshProUGUI materials;

    private static PermanentUpgrade upgradeInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (upgradeInstance == null)
        {
            upgradeInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }


    private void Update()
    {

        ShowPlayerStats();
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

    private void ShowPlayerStats()
    {
        if (_PlayerStats == null)
        {
            _PlayerStats = FindAnyObjectByType<PlayerStats>();
        }

        healthStat.text = "Health: " + _PlayerStats.currentHealth;
        damageStat.text = "Damage: " + _PlayerStats.damage;
        speedStat.text = "Speed: " + _PlayerStats.speed;
        materials.text = "Materials: " + _PlayerStats.materials;
    }
}

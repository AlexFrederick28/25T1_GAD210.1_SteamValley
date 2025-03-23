using JetBrains.Annotations;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] PermanentUpgrade _PermanentUpgrade;

    [SerializeField] private int currentHealth;
    public int maxHealth;
    public float speed;
    [SerializeField] private int damage;
    public int level;
    public int materials;

   
    public void UpgradeHealth()
    {
        if (materials >= _PermanentUpgrade.healthCost)
        {

            maxHealth += _PermanentUpgrade.healthUpgrade;
            currentHealth = maxHealth;

            level += 1;

            materials -= _PermanentUpgrade.healthCost;

            _PermanentUpgrade.healthCost += level;

        }
    }

    public void UpgradeDamage()
    {
        if (materials >= _PermanentUpgrade.damageCost)
        {

            damage += _PermanentUpgrade.damageUpgrade;

            level += 1;

            materials -= _PermanentUpgrade.damageCost;

            _PermanentUpgrade.damageCost += level;

        }
    }

    public void UpgradeSpeed()
    {
        if (materials >= _PermanentUpgrade.speedCost)
        {

            speed += _PermanentUpgrade.speedUpgrade;

            level += 1;

            materials -= _PermanentUpgrade.speedCost;

            _PermanentUpgrade.speedCost += level;

        }
    }

}

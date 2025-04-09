using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] PermanentUpgrade _PermanentUpgrade;

    public int currentHealth;
    public int maxHealth;
    public float speed;
    public int damage;
    public int level;
    public int materials;

    private static PlayerStats playerInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

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

    private void Update()
    {
        OnDeath();

        HidePlayerInCamp();
    }

    private void OnDeath()
    {
        if (currentHealth <= 0)
        {
            Scene currentScene = SceneManager.GetActiveScene();

            SceneManager.LoadScene(1);

            currentHealth = maxHealth;
        }
    }

    private void HidePlayerInCamp()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene == SceneManager.GetSceneByBuildIndex(1))
        {
            SpriteRenderer playerSprite = gameObject.GetComponent<SpriteRenderer>();

            playerSprite.enabled = false;
        }
        else
        {
            SpriteRenderer playerSprite = gameObject.GetComponent<SpriteRenderer>();

            playerSprite.enabled = true;
        }
    }

    public void SwapScenes()
    {
        SceneManager.LoadScene(2);
    }

}

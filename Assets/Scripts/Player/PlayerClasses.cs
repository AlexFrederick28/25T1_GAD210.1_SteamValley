using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerClasses : MonoBehaviour
{
    [SerializeField] private enum classTypes { Warrior, Mage, Hunter };
    [SerializeField] private string chosenClass;

    private PlayerStats _playerStats;

    public void InitialiseClass()
    {
        switch (chosenClass)
        {
            case "Warrior":
                
                    _playerStats = FindAnyObjectByType<PlayerStats>();
                    _playerStats.currentHealth = 15;
                    _playerStats.maxHealth = 15;
                    _playerStats.speed = 0.5f;
                    _playerStats.damage = 1;

                SceneManager.LoadScene(1);
                
                break;
            case "Mage":
                
                    _playerStats = FindAnyObjectByType<PlayerStats>();
                    _playerStats.currentHealth = 4;
                    _playerStats.maxHealth = 4;
                    _playerStats.speed = 1f;
                    _playerStats.damage = 3;

                SceneManager.LoadScene(1);

                break;
            case "Hunter":
                
                    _playerStats = FindAnyObjectByType<PlayerStats>();
                    _playerStats.currentHealth = 5;
                    _playerStats.maxHealth = 5;
                    _playerStats.speed = 2f;
                    _playerStats.damage = 2;

                SceneManager.LoadScene(1);

                break;



        }
    }
}

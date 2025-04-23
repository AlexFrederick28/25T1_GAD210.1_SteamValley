using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] private PlayerStats _PlayerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyBehaviour>())
        {
            collision.GetComponent<EnemyBehaviour>().health -= _PlayerStats.damage;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyBehaviour>())
        {
            collision.GetComponent<EnemyBehaviour>().health -= _PlayerStats.damage;
        }
    }

    private void Update()
    {
        GetReferences();
    }

    private void GetReferences()
    {
        if (_PlayerStats == null)
        {
            _PlayerStats = FindAnyObjectByType<PlayerStats>();
        }
    }
}

using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    [SerializeField] private PlayerStats _PlayerStats;
    [SerializeField] private Abilities _Abilities;

    private void Update()
    {
        if (_Abilities == null)
        {
            _PlayerStats = FindAnyObjectByType<PlayerStats>();
            _Abilities = FindAnyObjectByType<Abilities>();
        }

        Destroy(gameObject, 8f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyBehaviour>())
        {
            collision.gameObject.GetComponent<EnemyBehaviour>().health -= _PlayerStats.damage;

            Destroy(gameObject);
        }
    }
}

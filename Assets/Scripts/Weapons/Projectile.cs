using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private PlayerStats _PlayerStats;
    [SerializeField] private Abilities _Abilities;
    [SerializeField] private int damage;
    [SerializeField] private float speed;

    private void Update()
    {
        if (_Abilities == null)
        {
            _PlayerStats = FindAnyObjectByType<PlayerStats>();
            _Abilities = FindAnyObjectByType<Abilities>();
        }

        damage = _PlayerStats.damage;

        transform.position += _Abilities.shootTowardsMouse * speed * Time.deltaTime;

        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyBehaviour>())
        {
            collision.gameObject.GetComponent<EnemyBehaviour>().health -= damage;

            Destroy(gameObject);
        }
    }
}

using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private PlayerStats player;

    public int health = 4;
    [SerializeField] private float speed;
    [SerializeField] private int damage;

    private void Start()
    {
        if (player == null)
        {
            player = FindAnyObjectByType<PlayerStats>();
        }
    }

    private void Update()
    {
        MoveToPlayer();

        if (health <= 0)
        {
            player.materials += 5;

            Destroy(gameObject);
        }
    }

    private void MoveToPlayer()
    {
        Vector3 move = new(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y, 0);

        transform.position += speed * Time.deltaTime * move.normalized;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerStats>())
        {
            player.currentHealth -= damage;
        }
    }
}

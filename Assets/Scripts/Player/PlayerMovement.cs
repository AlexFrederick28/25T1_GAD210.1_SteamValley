using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private PlayerStats _PlayerStats;

    [SerializeField] private Rigidbody2D playerRigid;

    [SerializeField] private float speed;

    [SerializeField] private Vector2 moveInput;

    private void Update()
    {
        MovePLayer();
    }

    private void MovePLayer()
    {

        if (_PlayerStats == null)
        {
            playerRigid = GetComponent<Rigidbody2D>();
            _PlayerStats = GetComponent<PlayerStats>();
        }

        speed = _PlayerStats.speed;

        // MOVEMENT UPDATES

        moveInput.x = Input.GetAxisRaw("Horizontal"); // left right
        moveInput.y = Input.GetAxisRaw("Vertical"); // up down

        moveInput.Normalize(); // keeps movement fluid

        playerRigid.linearVelocity = moveInput * speed; // enabling movement
    }
}

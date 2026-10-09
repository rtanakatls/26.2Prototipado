using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
    }
}

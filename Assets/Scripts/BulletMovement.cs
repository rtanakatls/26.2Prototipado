using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    private Vector2 direction;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    private void Update()
    {
        rb.linearVelocity = direction * speed;
    }


}

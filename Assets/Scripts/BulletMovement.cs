using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;

    private Vector2 direction;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
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

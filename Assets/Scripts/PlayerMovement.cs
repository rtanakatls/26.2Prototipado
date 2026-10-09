using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Keyboard.current.aKey.isPressed)
        {
            rb.linearVelocity=new Vector2(-speed, rb.linearVelocity.y);
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }

    }
}

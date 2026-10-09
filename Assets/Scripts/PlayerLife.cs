using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int life;
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life--;
            if (life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}

using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] private int life;


    private void ChangeLife(int value)
    {
        life += value;
        if(life<= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PlayerBullet"))
        {
            ChangeLife(-1);
            Destroy(other.gameObject);
        }
    }
}

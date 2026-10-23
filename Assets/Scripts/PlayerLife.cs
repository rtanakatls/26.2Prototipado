using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int life;
    private int maxLife;
    [SerializeField] private Image lifeBar;

    private void Awake()
    {
        maxLife = life;
    }

    private void ChangeLife(int value)
    {
        life += value;
        lifeBar.fillAmount = (float)life / maxLife;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ChangeLife(-1);
        }
    }

}

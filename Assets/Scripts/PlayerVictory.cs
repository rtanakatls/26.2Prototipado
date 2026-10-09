using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVictory : MonoBehaviour
{
    [SerializeField] private int score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Flag"))
        {
            SceneManager.LoadScene("VictoryScene");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            score++;
            Destroy(collision.gameObject);
        }
    }
}

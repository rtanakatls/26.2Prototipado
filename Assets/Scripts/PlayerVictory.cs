using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVictory : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Flag"))
        {
            SceneManager.LoadScene("VictoryScene");
        }

    }
}

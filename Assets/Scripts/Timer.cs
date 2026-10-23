using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timer;
    private Image image;
    private float maxTime;

    private void Awake()
    {
        maxTime = timer;
        image=GetComponent<Image>();
    }

    private void Update()
    {
        timer-= Time.deltaTime;
        image.fillAmount = timer / maxTime;
    }

}

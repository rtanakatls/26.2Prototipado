using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private Vector2 direction;

    private void Awake()
    {
        direction.x = transform.localScale.x;
    }


    private void Update()
    {
        if(Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(direction);
        }
    }



}

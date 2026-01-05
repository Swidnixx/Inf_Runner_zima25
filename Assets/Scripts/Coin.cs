using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 1;
 
    Transform player;

    private void Start()
    {
        player = FindFirstObjectByType<Player>().transform;
    }

    private void Update()
    {
        if (GameManager.Instance.magnet.Active)
        {
            float distance = Vector2.Distance(player.position, 
                transform.position);

            if (distance < GameManager.Instance.magnet.Range)
            {
                transform.position = Vector2.MoveTowards(transform.position,
                    player.position, speed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.Instance.AddCoin();
            SoundManager.Instance.PlayCoin();
        }
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D rb;
    SpriteRenderer sr;
    int jumps = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && jumps < 2)
        {
            //rb.AddForce(new Vector2(0, force));
            rb.linearVelocity = new Vector2(0, speed);
            jumps++;
            SoundManager.Instance.PlayJump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            sr.color = Color.green;
            jumps = 0; 
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            sr.color = Color.red; 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
        }
    }
}

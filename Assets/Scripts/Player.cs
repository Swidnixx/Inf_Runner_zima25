using UnityEngine;

public class Player : MonoBehaviour
{
    public float force = 10;
    public float speed = 10;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //rb.AddForce(new Vector2(0, force));
            rb.velocity = new Vector2(0, speed);
        }
    }
}

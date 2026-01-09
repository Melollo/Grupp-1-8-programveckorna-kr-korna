using UnityEngine;

public class LeMouvement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(5, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector2(-5, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = new Vector2(0, 5);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = new Vector2(0, -5);
        }
    }
}

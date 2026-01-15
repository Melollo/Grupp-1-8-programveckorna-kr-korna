using UnityEngine;

public class textmoveup : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(0, 0);
        rb.linearVelocity = new Vector2(0, speed);

    }
}

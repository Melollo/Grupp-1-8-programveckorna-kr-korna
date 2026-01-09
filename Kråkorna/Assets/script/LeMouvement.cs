using UnityEngine;

public class LeMouvement : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator =GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("iswalkup", false);
        animator.SetBool("iswalkleft", false);
        animator.SetBool("iswalkdown", false);
        animator.SetBool("iswalkright", false);
        rb.linearVelocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(5, 0);
            animator.SetBool("iswalkright", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector2(-5, 0);
            animator.SetBool("iswalkleft", true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = new Vector2(0, 5);
            animator.SetBool("iswalkup", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = new Vector2(0, -5);
            animator.SetBool("iswalkdown", true);
        }
    }
}

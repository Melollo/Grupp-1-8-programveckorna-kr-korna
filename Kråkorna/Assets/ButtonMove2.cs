using UnityEngine;

public class ButtonMove2 : MonoBehaviour
{
    public float amplitude = 0.2f;
    public float speed = 1f;
    private float startY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startY + Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        float rotation = 30 + -newY * 0.1f;
        transform.eulerAngles = Vector3.forward * rotation;

    }
}
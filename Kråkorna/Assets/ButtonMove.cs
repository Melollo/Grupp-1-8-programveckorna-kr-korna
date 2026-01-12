using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public float amplitude = 0.2f;
    public float speed = 1f;
    private float startY;
    public float tiltAngle = 5f;    
    public float tiltSpeed = 2f;
    private RectTransform rectTransform;
    private Quaternion startRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startY = transform.position.y;
        rectTransform = GetComponent<RectTransform>();
        startRotation = rectTransform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startY + Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        float tilt = Mathf.Sin(Time.time * tiltSpeed) * tiltAngle;
        rectTransform.localRotation = startRotation * Quaternion.Euler(0f, 0f, tilt);


    }
}
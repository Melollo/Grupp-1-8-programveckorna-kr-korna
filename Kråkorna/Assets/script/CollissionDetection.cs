using UnityEngine;

public class CollissionDetection : MonoBehaviour
{

    public GameObject isGreen;
    public GameObject isRed;
    public GameObject trueGreen;
    public GameObject trueYellow;

    public bool colliding = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        isGreen.SetActive(false);
        isRed.SetActive(false);
        trueGreen.SetActive(false);
        trueYellow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (colliding)
        {
            isGreen.SetActive(true);
            isRed.SetActive(false);
            trueGreen.SetActive(true);
            trueYellow.SetActive(false);

            CodeCheckerScript.Instance.puzzleSolved = true;

        }
        else
        {

            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueGreen.SetActive(false);
            trueYellow.SetActive(true);

            CodeCheckerScript.Instance.puzzleSolved = false;

        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trueBlock"))
        {
            colliding = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trueBlock"))
        {
            colliding = false;
        }
    }

}

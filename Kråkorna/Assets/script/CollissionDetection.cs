using UnityEngine;

public class CollissionDetection : MonoBehaviour
{

    public CodeCheckerScript codeCheckerScript;

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

        }
        else
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueGreen.SetActive(false);
            trueYellow.SetActive(true);

        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trueBlock"))
        {
            SolvePuzzle();
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

    void SolvePuzzle()
    {
        codeCheckerScript.SolvePuzzle();
    }

}

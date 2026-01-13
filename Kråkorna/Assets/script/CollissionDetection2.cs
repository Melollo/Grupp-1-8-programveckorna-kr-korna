using UnityEngine;

public class CollissionDetection2 : MonoBehaviour
{

    public GameObject isGreen;
    public GameObject isRed;
    public GameObject trueGreen;
    public GameObject trueYellow;
    public GameObject falseGreen;
    public GameObject falseYellow;

    public bool collidingTrue = false;
    public bool collidingFalse = false;

    public GameObject trueTwoYellow;
    public GameObject trueTwoRed;

    public bool collidingTrueTwo = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        isGreen.SetActive(false);
        isRed.SetActive(false);
        trueGreen.SetActive(false);
        trueYellow.SetActive(false);
        falseGreen.SetActive(false);
        falseYellow.SetActive(false);
        trueTwoYellow.SetActive(false);
        trueTwoRed.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (collidingTrue)
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueGreen.SetActive(false);
            trueYellow.SetActive(true);
        }
        else
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueGreen.SetActive(true);
            trueYellow.SetActive(false);
        }

        if (collidingTrueTwo)
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueTwoYellow.SetActive(false);
            trueTwoRed.SetActive(true);
        }
        else
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueTwoYellow.SetActive(true);
            trueTwoRed.SetActive(false);
        }

        if (collidingFalse)
        {
            isGreen.SetActive(true);
            isRed.SetActive(false);
            falseGreen.SetActive(true);
            falseYellow.SetActive(false);
        }
        else
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            falseGreen.SetActive(false);
            falseYellow.SetActive(true);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("falseBlock"))
        {
            collidingFalse = true;
        }
        if (collision.gameObject.CompareTag("trueBlock"))
        {
            collidingTrue = true;
        }
        if (collision.gameObject.CompareTag("trueBlockTwo"))
        {
            collidingTrueTwo = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("falseBlock"))
        {
            collidingFalse = false;
        }
        if (collision.gameObject.CompareTag("trueBlock"))
        {
            collidingTrue = false;
        }
        if (collision.gameObject.CompareTag("trueBlockTwo"))
        {
            collidingTrueTwo = false;
        }
    }

}

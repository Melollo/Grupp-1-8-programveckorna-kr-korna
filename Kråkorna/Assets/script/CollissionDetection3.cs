using UnityEngine;

public class CollissionDetection3 : MonoBehaviour
{

    public CodeCheckerScript codeCheckerScript;

    public GameObject isGreen;
    public GameObject isRed;
    public GameObject isTwoGreen;
    public GameObject isTwoRed;
    public GameObject isThreeGreen;
    public GameObject isThreeRed;

    public GameObject trueYellow;
    public GameObject trueGreen;
    public GameObject trueRed;
    public GameObject trueTwoYellow;
    public GameObject trueTwoGreen;
    public GameObject trueTwoRed;

    public GameObject falseGreen;
    public GameObject falseYellow;
    public GameObject falseRed;
    public GameObject falseTwoGreen;
    public GameObject falseTwoYellow;
    public GameObject falseTwoRed;

    public bool collidingTrue = false;
    public bool collidingTrueTwo = false;

    public bool collidingFalse = false;
    public bool collidingFalseTwo = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        isGreen.SetActive(false);
        isRed.SetActive(false);
        isTwoGreen.SetActive(false);
        isTwoRed.SetActive(false);
        isThreeGreen.SetActive(false);
        isThreeRed.SetActive(false);

        trueGreen.SetActive(false);
        trueYellow.SetActive(false);
        trueRed.SetActive(false);
        trueTwoGreen.SetActive(false);
        trueTwoYellow.SetActive(false);
        trueTwoRed.SetActive(false);

        falseGreen.SetActive(false);
        falseYellow.SetActive(false);
        falseRed.SetActive(false);
        falseTwoGreen.SetActive(false);
        falseTwoYellow.SetActive(false);
        falseTwoRed.SetActive(false);

        codeCheckerScript.puzzleSolved = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (collidingTrue)
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueGreen.SetActive(false);
            trueYellow.SetActive(false);
            trueRed.SetActive(true);
        }
        else
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueGreen.SetActive(false);
            trueYellow.SetActive(true);
            trueRed.SetActive(false);
        }

        if (collidingTrueTwo)
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueTwoYellow.SetActive(false);
            trueTwoRed.SetActive(true);
            trueTwoGreen.SetActive(false);
        }
        else
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            trueTwoYellow.SetActive(true);
            trueTwoRed.SetActive(false);
            trueTwoGreen.SetActive(false);
        }

        if (collidingFalse)
        {
            isGreen.SetActive(true);
            isRed.SetActive(false);
            falseGreen.SetActive(true);
            falseYellow.SetActive(false);
            falseRed.SetActive(false);
        }
        else
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            falseGreen.SetActive(false);
            falseYellow.SetActive(true);
            falseRed.SetActive(false);
        }

        if (collidingFalseTwo)
        {
            isGreen.SetActive(true);
            isRed.SetActive(false);
            falseTwoGreen.SetActive(true);
            falseTwoYellow.SetActive(false);
            falseTwoRed.SetActive(false);
        }
        else
        {
            isGreen.SetActive(false);
            isRed.SetActive(true);
            falseTwoGreen.SetActive(false);
            falseTwoYellow.SetActive(true);
            falseTwoRed.SetActive(false);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("falseBlock"))
        {
            collidingFalse = true;
        }
        if (collision.gameObject.CompareTag("falseBlockTwo"))
        {
            collidingFalseTwo = true;
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
        if (collision.gameObject.CompareTag("falseBlockTwo"))
        {
            collidingFalseTwo = false;
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

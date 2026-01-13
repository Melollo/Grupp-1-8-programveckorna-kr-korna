using UnityEngine;

public class IsBlockSimple : MonoBehaviour
{
    // What this IS block wants
    public bool wantsTrue;

    // Visuals
    public GameObject green;
    public GameObject red;

    // Current connection
    bool isCorrect = false;

    void Update()
    {
        green.SetActive(isCorrect);
        red.SetActive(!isCorrect);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TrueBlock"))
        {
            isCorrect = wantsTrue;
        }

        if (collision.gameObject.CompareTag("FalseBlock"))
        {
            isCorrect = !wantsTrue;
        }

        if (isCorrect)
        {
            CodeCheckerScript.Instance.puzzleThreeSolved++;
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TrueBlock") ||
            collision.gameObject.CompareTag("FalseBlock"))
        {
            isCorrect = false;
        }

        if (isCorrect == false)
        {
            CodeCheckerScript.Instance.puzzleThreeSolved--;
        }

    }
}

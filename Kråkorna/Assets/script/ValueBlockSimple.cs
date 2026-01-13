using UnityEngine;

public class ValueBlockSimple : MonoBehaviour
{
    public bool isTrueBlock;

    public GameObject yellow;
    public GameObject green;
    public GameObject red;

    void Start()
    {
        SetYellow();
    }

    void SetYellow()
    {
        yellow.SetActive(true);
        green.SetActive(false);
        red.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        IsBlockSimple isBlock = collision.gameObject.GetComponent<IsBlockSimple>();

        if (isBlock != null)
        {
            bool correct = (isTrueBlock == isBlock.wantsTrue);

            yellow.SetActive(false);
            green.SetActive(correct);
            red.SetActive(!correct);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<IsBlockSimple>() != null)
        {
            SetYellow();
        }
    }
}

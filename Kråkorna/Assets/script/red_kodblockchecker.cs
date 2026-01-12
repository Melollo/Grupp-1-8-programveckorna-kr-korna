using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class red_kodblockchecker : MonoBehaviour
{
    SpriteRenderer sr;
    [SerializeField] private string the_tag;
    [SerializeField] private Color c;
    [SerializeField] private Color reset;
    bool mommyhentai = false;
    public taker taker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (mommyhentai == true)
        {
            sr.color = c;
            //Debug.Log("hit");
            taker.spongebob = true;
        }
        else
        {
             sr.color = reset;
            taker.spongebob = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == the_tag)
        {
            mommyhentai = true;
        }
        //sr.color = reset;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == the_tag)
        {
            mommyhentai = false;
        }

    }
}


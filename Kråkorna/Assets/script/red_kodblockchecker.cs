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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == the_tag)
        {
            sr.color = c;
            Debug.Log("hit");
        }
        //sr.color = reset;
    }
}


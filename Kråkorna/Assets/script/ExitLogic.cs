using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLogic : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public string nextScene = "";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        CodeCheckerScript.Instance.meth = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CodeCheckerScript.Instance.puzzleSolved == true)
        {
            spriteRenderer.enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            
            if (CodeCheckerScript.Instance.puzzleSolved == true)
            {
                CodeCheckerScript.Instance.puzzleSolved = false;
                SceneManager.LoadScene(nextScene);
            
            }
            else
            {

            }

        }

    }

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class creditsreset : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        new WaitForSeconds(200f);
        SceneManager.LoadScene("StartScreen");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    [SerializeField] string startScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void start()
    {
        SceneManager.LoadSceneAsync(startScene);
    }
}

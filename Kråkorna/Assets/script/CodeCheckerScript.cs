using UnityEngine;

public class CodeCheckerScript : MonoBehaviour
{

    public bool puzzleSolved = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SolvePuzzle()
    {
        puzzleSolved=true;
    }

}

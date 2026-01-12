using UnityEngine;

public class taker : MonoBehaviour
{
    SpriteRenderer sr;
    public bool spongebob = false;
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
        if (spongebob == true)
        {
            sr.color = c;
            //Debug.Log("spongebob");
        }
        else
        {
            sr.color= reset;
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

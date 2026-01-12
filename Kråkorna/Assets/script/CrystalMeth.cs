using UnityEngine;

public class CrystalMeth : MonoBehaviour
{

    public LeMouvement leMouvement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            leMouvement.speed = 20;
        }

    }

}

using UnityEngine;

public class AudioBanana : MonoBehaviour
{

    private AudioSource audioBanana;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioBanana = GetComponent<AudioSource>();
        audioBanana.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            
             audioBanana.Play();
           
        }
    }

}

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kodblockchecker : MonoBehaviour
{
    [SerializeField] private string the_tag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == the_tag)
        {
            SceneManager.LoadScene("ohio");
            Debug.Log("hit");
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision){
        
        
        //if (gameObject.CompareTag("blue"))// && gameObject.CompareTag("yellow")){
            //SceneManager.LoadScene("ohio");
        }
        
    //}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public AudioSource Snake;
   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullets") || collision.gameObject.CompareTag("Blasters"))
        {
            Snake.Play();
            Invoke("BBB", 2f);
        }
    }
    void BBB()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public AudioSource Birds;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullets") || collision.gameObject.CompareTag("Blasters"))
        {
           Birds.Play();
            Invoke("BBB",2f);

            
        }
    }
    void BBB()
    {
        Destroy(gameObject);
    }
}

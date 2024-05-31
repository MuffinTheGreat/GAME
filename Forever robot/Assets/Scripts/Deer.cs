using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : MonoBehaviour
{
    public AudioSource Deeeer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullets") || collision.gameObject.CompareTag("Blasters"))
        {
            Deeeer.Play();
            Invoke("BBB", 2f);
           
        }
    }
    void BBB()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumCount : MonoBehaviour
{
    public static int Hum=0;
    public AudioSource dead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullets"))
        {
            Hum++;
            dead.Play();
           
        }
    }
} 

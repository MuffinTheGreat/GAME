using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDESTROY : MonoBehaviour
{
    int lives=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lives<=0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blasters"))
        {

            lives = lives - 7;
        }
        if (collision.gameObject.CompareTag("Bullets"))
        {
            Invoke("Slow", 0.5f);
           
        }
    }
    void Slow()
    {
        lives = lives - 10;
    }
}

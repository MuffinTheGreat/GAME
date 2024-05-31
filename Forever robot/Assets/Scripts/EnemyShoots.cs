using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoots : MonoBehaviour
{
    bool openFire = true;
    public Camera cam;
    public GameObject bull;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Ch", 0.5f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (openFire == true)
        {
            GameObject bullet = Instantiate(bull);
            bullet.transform.position = transform.position;
            Vector3 dir = cam.transform.position;
            bullet.GetComponent<Rigidbody>().AddForce(dir * 150);
            openFire = false;
           
        }
       
    }
    private void Ch()
    {
        openFire = true;
    }
}

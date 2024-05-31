using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySHOOTS1 : MonoBehaviour
{
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    public Transform ShootPoint;
    public GameObject Bu;
    int buSpeed = 150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Time.time > nextFire)
        {
            if (!Bu)
                return;
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(Bu, ShootPoint.position, ShootPoint.rotation);
            Rigidbody rb = clone.GetComponent<Rigidbody>();
            rb.AddRelativeForce(Vector3.forward * buSpeed, ForceMode.Impulse);

        }
    }
}

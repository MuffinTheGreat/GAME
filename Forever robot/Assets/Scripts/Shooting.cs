using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform BulletSpawn;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(BulletSpawn.position, BulletSpawn.forward * 100, Color.red);
        RaycastHit hit;

        if (Input.GetButtonDown("Fire1"))
        {


            GameObject Shoot = Instantiate(Bullet, BulletSpawn.position, Quaternion.identity);

            if (Physics.Raycast(ray, out hit, 100f))
            {

                Shoot.GetComponent<Rigidbody>().AddForce(-hit.normal * 50, ForceMode.Impulse);
            }
        }
    }
}

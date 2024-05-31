using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot20 : MonoBehaviour
{
    public GameObject Bullet;
    public Transform SpawnBullet;
    public Camera camera;
    public float power;
    int bullets = 20;
    public AudioSource GunShot;
    public AudioSource BulletCase;
    public AudioSource Reloading;
    public AudioSource NoneLeft;
    
    

    
    void Update()
    {
       
        if (Input.GetButtonDown("Fire1") && bullets > 0  )
        {
            
            Shooot();
            bullets--;
            GunShot.Play();
            Invoke("BulletCases", 0.5f);
            Invoke("Reload", 1.5f);

        }
        if(Input.GetButtonDown("Fire1") && bullets ==0)
        {
            NoneLeft.Play();
        }
    }
    
    
    void BulletCases()
    {
        BulletCase.Play();
    }
    void Reload()
    {
        Reloading.Play();
    }
    private void Shooot()
    {
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Vector3 target;
        if (Physics.Raycast(ray, out hit))
        {
            target = hit.point;
        }
        else
        {
            target = ray.GetPoint(10);
        }

        Vector3 dir = target - SpawnBullet.position;
        GameObject currently = Instantiate(Bullet, SpawnBullet.position, Quaternion.identity);
        currently.transform.forward = dir.normalized;
        currently.GetComponent<Rigidbody>().AddForce(dir.normalized * power, ForceMode.Impulse);
    }
}

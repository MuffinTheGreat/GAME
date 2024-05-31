using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform SpawnBullet;
    public Camera camera;
    public float power;
    public AudioSource Blaster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Shooot();
            Blaster.Play();
            
        }
    }
    private void Shooot()
    {
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Vector3 target;
        if(Physics.Raycast(ray,out hit))
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

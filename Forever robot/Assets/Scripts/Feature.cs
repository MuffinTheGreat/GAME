using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feature : MonoBehaviour
{
    public List<GameObject> Gears = new List<GameObject>();
    public Transform Orientation;

    public Light lights;
    bool lightOn;

    public AudioSource bam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            int index = Random.Range(0, Gears.Count);
            Instantiate(Gears[index], transform.position + new Vector3(Orientation.forward.x * 2, 0, Orientation.forward.z * 2), Quaternion.identity);
            bam.Play();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!lightOn)
            {
                lights.intensity = 5;
                lightOn = true;
            }
            else
            {
                lights.intensity = 0;
                lightOn = false;
            }
        }
    }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Gear"))
            {
                Destroy(collision.gameObject);
            }
        }
    
}

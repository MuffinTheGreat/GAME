using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCase : MonoBehaviour
{
    public GameObject Case;
    int cases = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")&&cases>0)
        {
            Instantiate(Case, transform.position, Quaternion.identity);
            cases--;
        }
    }
}

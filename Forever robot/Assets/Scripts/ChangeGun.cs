using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGun : MonoBehaviour
{
    public GameObject FirstGun;
    public GameObject SecondGun;
    bool first = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            FirstGun.SetActive(first);
            first = !first;
            SecondGun.SetActive(first);
        }
    }
}

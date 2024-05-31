using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYbullet : MonoBehaviour
{ 
    void Start()
    {
        Invoke("DeleteMe", 2f);
    }
    void DeleteMe()
    {
        Destroy(gameObject);
    }
    
}

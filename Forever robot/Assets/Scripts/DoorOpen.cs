using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Door;
    Vector3 afterpos;
    Vector3 pos;
    //int did = 0;
   
    void Start()
    {
        pos = Door.transform.position;
        Debug.Log(pos);
    }

   
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Invoke("OPEN",0.1f);
           
        }
    }
    void OPEN()
    {
       // gameObject.Transform.localPosition
        Door.transform.position = Door.transform.position + new Vector3(0f, 0f, 0.5f);
       // did++;
    }
    private void OnCollisionExit(Collision collision)
    {
        Invoke("CLOSE", 1.3f);
        /*
        Debug.Log(did);
        afterpos = Door.transform.position;
        for (int i=0; i<did; i++)
        {
            //InvokeRepeating("CLOSE", 1f, 0.5f);
            Door.transform.position = Door.transform.position - new Vector3(0f, 0f, 1.5f);

            Debug.Log(afterpos);
        }
        */
    }
    void CLOSE()
    {
        Door.transform.position = pos;
        /*
            afterpos =afterpos - new Vector3(0f, 0f, 0.5f);
            
            Debug.Log(afterpos);
        */

    }
}

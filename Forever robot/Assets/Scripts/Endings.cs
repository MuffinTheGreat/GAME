using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class Endings : MonoBehaviour
{
    // public GameObject destroyVirus;
    public GameObject MAPmap;
    bool MAP = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            MAPmap.SetActive(MAP);
            MAP = !MAP;
           
        }
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ending"))
        {
           // destroyVirus.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            //Time.timeScale = 0f;
            Cursor.visible = true;
            SceneManager.LoadScene(7);
        }
    }
   
}

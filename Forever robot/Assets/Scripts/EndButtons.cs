using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Right()
    {
        if (HumCount.Hum == 0)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(5);
        }
    }
    public void Wrong()
    {

        SceneManager.LoadScene(6);

    }
}

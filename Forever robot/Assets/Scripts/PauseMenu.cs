using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject canvas;
    bool OnPause = false;
    KeyCode PauseKey = KeyCode.Escape;
    // Start is called before the first frame update
    void Start()
    {
        PauseKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), StaticHolder.PauseKey);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PauseKey))
        {
            OnPause = !OnPause;
            canvas.SetActive(OnPause);
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale =0f;
            Cursor.visible =true
;
        }
    }
    public void PauseOff()
    {
        OnPause = !OnPause;
        canvas.SetActive(OnPause);
        Time.timeScale= 1f;

        Cursor.lockState = CursorLockMode.Locked;
       
        Cursor.visible =false;

    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

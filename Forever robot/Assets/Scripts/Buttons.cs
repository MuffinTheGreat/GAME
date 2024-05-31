using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public TMPro.TMP_InputField KeyField;

    public AudioSource Au;
    //bool AuOff=false;
    public GameObject obcanvas;
    public GameObject music;
    

    void Start()
    {
        //Au.mute = StaticHolder.AuOff;
        
        Debug.Log(StaticHolder.AuOff);
        if (StaticHolder.AuOff==false)
        {
            Au.Play();
        }
        //Au.mute = AuOff;
    }
    public void Next()
    {
        obcanvas.SetActive(false);
    }
    public void NextNext()
    {
        SceneManager.LoadScene(3);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Settings()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void ChangePauseKey()
    {
        StaticHolder.PauseKey=KeyField.text;
    }
     public void MuteMusic()
    {
        StaticHolder.AuOff =!StaticHolder.AuOff;
       // AuOff = !AuOff; 
       
        //Au.Stop();
         Debug.Log(StaticHolder.AuOff+" muted");
        Au.mute = StaticHolder.AuOff;
    }


    void Update()
    {
       
        
    }
}

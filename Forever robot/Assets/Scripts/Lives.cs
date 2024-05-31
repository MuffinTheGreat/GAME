using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lives : MonoBehaviour
{
    public Slider slider;
    int lives_player=100;
    public GameObject gameover;
    bool Invisible=false;
    public AudioSource GameOVER;




    private void Update()
    {
        
        if (lives_player<=0)
        {
            GameOVER.Play();
            Invoke("Dead", 2f);
            
        }
    }
    void Dead()
    {
        gameover.SetActive(true);

        Invoke("BackToMenu", 5f);
    }
    void BackToMenu()
    {
      
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene(0);

    }
    void livel_sub()
    {
        Invisible = false;
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !Invisible)
        {
            Invisible = true;
            Invoke("livel_sub", 1f);
            lives_player =lives_player-10;
            Debug.Log(lives_player);
            slider.value = lives_player;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnBu") && !Invisible)
        {
            Invisible = true;
            Invoke("livel_sub", 1f);
            lives_player = lives_player -5;
            Debug.Log(lives_player);
            slider.value = lives_player;
        }
    }
    private void Start()
    {
        slider.value = lives_player;
    }
}

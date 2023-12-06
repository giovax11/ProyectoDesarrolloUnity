using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuLogic : MonoBehaviour
{
    private GameObject mainMenu;
    private GameObject optionsMenu;
    private GameObject loading;

    public AudioSource buttomSound;
    public AudioSource soundMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        soundMenu.Play();
        
        mainMenu = GameObject.Find("MainMenuCanvas");
        optionsMenu = GameObject.Find("OptionsCanvas");
        loading = GameObject.Find("LoadingCanvas");

        mainMenu.GetComponent<Canvas>().enabled = true;
        optionsMenu.GetComponent<Canvas>().enabled = false;
        loading.GetComponent<Canvas>().enabled = false;
    }

    public void StartButtom() {
        mainMenu.GetComponent<Canvas>().enabled = false;
        loading.GetComponent<Canvas>().enabled = true;
        buttomSound.Play();
        SceneManager.LoadScene("ChisrtmasgiftHouse");
    }

    public void OptionsButtom(){
        buttomSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = false;
        optionsMenu.GetComponent<Canvas>().enabled = true;
    }

    public void QuitButtom(){
        buttomSound.Play();
        Application.Quit();
    }

    public void ReturnToMainMenuButtom(){
        buttomSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = true;
        optionsMenu.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

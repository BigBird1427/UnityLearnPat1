using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class TitleScreen : MonoBehaviour
{
    public Button StartButton;
    public Canvas TitleShot;
    public Canvas Sett;
    public Canvas Credits;
   

    private void Awake(){
        //Sett.gameObject.SetActive(false);
        //Credits.gameObject.SetActive(false);
        StartButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked(){
        if(StartButton.gameObject.name == "Start"){
            SceneManager.LoadSceneAsync("Game");
            //SceneManager.UnloadSceneAsync("Title");
        }
        if(StartButton.gameObject.name == "Settings"){
            TitleShot.gameObject.SetActive(false);
            Sett.gameObject.SetActive(true);
            Credits.gameObject.SetActive(false);
        }
        if(StartButton.gameObject.name == "Credits"){
            TitleShot.gameObject.SetActive(false);
            Sett.gameObject.SetActive(false);
            Credits.gameObject.SetActive(true);
        }
        if(StartButton.gameObject.name == "Back"){
            TitleShot.gameObject.SetActive(true);
            Sett.gameObject.SetActive(false);
            Credits.gameObject.SetActive(false);
        }
    }
}

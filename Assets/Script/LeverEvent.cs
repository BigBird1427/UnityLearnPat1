using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LeverEvent : MonoBehaviour
{
    //Calls the function that would call the event OnLeverTrigger
    //When in proximity of the lever
    public Button Button1;

    //public void OnTriggerEnter2D(Collider2D col){}
    void Start(){
        Button1.gameObject.SetActive(false);
    }

    private void Awake(){
        Button1.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked(){
        EventController.current.LeverTrigger();
    }

    public void OnTriggerStay2D(Collider2D col){
        //Debug.Log(col.gameObject.tag);
        Button1.gameObject.SetActive(true);
        if(col.gameObject.CompareTag("Player"))
        {
            if(Input.GetKey(KeyCode.Return)){
            EventController.current.LeverTrigger();
            }
        }
    }

     public void OnTriggerExit2D(Collider2D col){
        //Debug.Log(col.gameObject.tag);
        Button1.gameObject.SetActive(false);
        if(col.gameObject.CompareTag("Player"))
        {
            //EventController.current.LeverExit();
        }
    }
}

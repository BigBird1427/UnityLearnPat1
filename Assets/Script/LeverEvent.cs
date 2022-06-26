using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LeverEvent : MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player"))
        {
            EventController.current.EnterLever();
        }
    }

     public void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.CompareTag("Player"))
        {
            EventController.current.LeverExit();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverEvent : MonoBehaviour
{
    //Calls the function that would call the event OnLeverTrigger
    //When in proximity of the lever
    private void OnTriggerEnter2D(Collider2D other){
        EventController.current.LeverTrigger();
    }

    //Calls the function that would call the event OnLeverExit
    //When leaving proximity of the lever
    private void OnTriggerExit2D(Collider2D other){
        EventController.current.LeverExit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverEvent : MonoBehaviour
{
    //Calls the function that would call the event OnLeverTrigger
    //When in proximity of the lever

    public void OnCollisionStay2D(Collision2D col){
        //Debug.Log(col.gameObject.tag);
        if(col.gameObject.CompareTag("Player"))
        {
            if(Input.GetKey(KeyCode.Return))
            EventController.current.LeverTrigger();
        }
    }

     public void OnCollisionExit2D(Collision2D col){
        //Debug.Log(col.gameObject.tag);
        if(col.gameObject.CompareTag("Player"))
        {
            EventController.current.LeverExit();
        }
    }
}

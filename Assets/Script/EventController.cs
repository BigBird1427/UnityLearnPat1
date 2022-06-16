//Testing Github Commits Shane Bailey


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;
using System;

public class EventController : MonoBehaviour
{
    //Creates an EventController Object
    public static EventController current;
    //Intiatizles the Object
    private void Awake()
    {
        current = this;
    }

    
    //Events that can be subscibe to
    public event Action OnLeverTrigger;
    public event Action OnLeverExit;

    //A function to invoke an event
    public void LeverTrigger()
    { 
        //Makes sure that event isn't empty
        if(OnLeverTrigger != null)
        {
            OnLeverTrigger();
        }
    }
    
    //A function to invoke an event
    public void LeverExit()
    {
        //Makes sure that event isn't empty
        if(OnLeverExit != null)
        {
            OnLeverExit();
        }
    }

}
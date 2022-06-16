using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class DoorState : MonoBehaviour
{
    //Allows for these to be defined in Unity
    public SpriteRenderer spriteRenderer;
    public Sprite Standard;
    public Sprite newSprite;
    public Collider2D DoorCollider;

    //Gets the collider 
    //Subscribes The Door functions to the according event(Action)
    private void Start()
    {
        DoorCollider = GetComponent<Collider2D>();
        EventController.current.OnLeverTrigger += DoorUnlock;
        EventController.current.OnLeverExit += DoorLock;
    }

    
    public void DoorUnlock()
    {
        DoorCollider.enabled = false;
        spriteRenderer.sprite = newSprite;
    }

    public void DoorLock()
    {
        DoorCollider.enabled = true;
        spriteRenderer.sprite = Standard;
    }
}

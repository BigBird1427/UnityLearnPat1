using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float X;
    public float Y;
    
    private KeyCode lastHitKey;
    private Animator animator;
    private Rigidbody2D myRigidbody;
    private Vector2 zeroSpeed;

    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        

        zeroSpeed = new Vector2(0.0f,0.0f);
    }

    void Speed(){
        X = 0;
        Y = 0;

        animator.SetInteger("TymeLeft", 0);
        animator.SetInteger("TymeRight", 0);
        animator.SetInteger("TymeBack", 0);
        animator.SetInteger("TymeWalkUP", 0);
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            Speed();
            Y = 2;
            animator.SetInteger("TymeWalkUP",1);
            lastHitKey = KeyCode.W;
        }
        if(Input.GetKeyDown(KeyCode.S)){
            Speed();
            Y = -2;
            animator.SetInteger("TymeBack",1);
            lastHitKey = KeyCode.S;
        }
        if(Input.GetKeyDown(KeyCode.A)){
            Speed();
            X = -2;
            animator.SetInteger("TymeLeft",1);
            lastHitKey = KeyCode.A;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            Speed();
            X = 2;
            animator.SetInteger("TymeRight",1);
            lastHitKey = KeyCode.D;
        }


        if(Input.GetKeyDown(KeyCode.Q)){

        }
        

        if(Input.GetKeyUp(KeyCode.W) && lastHitKey == KeyCode.W){
            Speed();
            animator.SetInteger("BaseBack",1);
        }
        if(Input.GetKeyUp(KeyCode.S) && lastHitKey == KeyCode.S){
            Speed();
            animator.SetInteger("BaseFront",1);
        }
        if(Input.GetKeyUp(KeyCode.A) && lastHitKey == KeyCode.A){
            Speed();
            animator.SetInteger("BaseLeft",1);
        }
        if(Input.GetKeyUp(KeyCode.D) && lastHitKey == KeyCode.D){
            Speed();
            animator.SetInteger("BaseRight",1);
        }
        myRigidbody.velocity = new Vector2(this.X,this.Y);


         if(X != 0  || Y != 0 ){
                animator.SetInteger("BaseBack", 0);
                animator.SetInteger("BaseFront", 0);
                animator.SetInteger("BaseLeft", 0);
                animator.SetInteger("BaseRight", 0);
        }

        

        

        
    }
}

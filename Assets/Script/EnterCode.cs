using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;

public class EnterCode : MonoBehaviour
{
    //Button DecreaseNumber1 = GameObject.Find("DecreaseNumber1").GetComponent<Button>();
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<UIDocument>().gameObject.SetActive(false);
        EventController.current.OnEnterLever += VisualUpdate;
        EventController.current.OnLeverExit += R;
    }
    Button DecreaseNumber1;
    Button IncreaseNumber1;
    Button DecreaseNumber2;
    Button IncreaseNumber2;
    Button DecreaseNumber3;
    Button IncreaseNumber3;
    Label Number1;
    Label Number2;
    Label Number3;
    int Num1 = 0;
    int Num2 = 0;
    int Num3 = 0;

    Button Return;
    Button Enter;
    private void OnEnable(){
        var root = GetComponent<UIDocument>().rootVisualElement;
        Return = root.Q<Button>("Return");
        Return.RegisterCallback<ClickEvent>(ev => R());
        Enter = root.Q<Button>("Enter");
        Enter.RegisterCallback<ClickEvent>(ev => E());

        Number1 = root.Q<Label>("CodeOne");
        DecreaseNumber1 = root.Q<Button>("DecreaseNumber1");
        DecreaseNumber1.RegisterCallback<ClickEvent>(ev => NumberDecrease(1));
        IncreaseNumber1 = root.Q<Button>("IncreaseNumber1");
        IncreaseNumber1.RegisterCallback<ClickEvent>(ev => NumberIncrease(1));

        Number2 = root.Q<Label>("CodeTwo");
        DecreaseNumber2 = root.Q<Button>("DecreaseNumber2");
        DecreaseNumber2.RegisterCallback<ClickEvent>(ev => NumberDecrease(2));
        IncreaseNumber2 = root.Q<Button>("IncreaseNumber2");
        IncreaseNumber2.RegisterCallback<ClickEvent>(ev => NumberIncrease(2));

        Number3 = root.Q<Label>("CodeThree");
        DecreaseNumber3 = root.Q<Button>("DecreaseNumber3");
        DecreaseNumber3.RegisterCallback<ClickEvent>(ev => NumberDecrease(3));
        IncreaseNumber3 = root.Q<Button>("IncreaseNumber3");
        IncreaseNumber3.RegisterCallback<ClickEvent>(ev => NumberIncrease(3));
        
    }
    private void NumberDecrease(int number){
        if(number ==1){Num1--;}
        else if(number ==2){Num2--;}
        else if(number ==3){Num3--;}
        NumberUpdate();
    }
    private void NumberIncrease(int number){
        if(number ==1){Num1++;}
        else if(number ==2){Num2++;}
        else if(number ==3){Num3++;}
        NumberUpdate();
    }
    private void NumberUpdate(){
        Num1 = size(Num1);
        Num2 = size(Num2);
        Num3 = size(Num3);
        Number1.text = $"{Num1}";
        Number2.text = $"{Num2}";
        Number3.text = $"{Num3}";
    }
    private int size(int n){
        if(n>9){
            return 0;
        }else if(n<0){
            return 9;
        }
        return n;
    }

    public void R(){
        GetComponent<UIDocument>().gameObject.SetActive(false);
        Num1 = 0;
        Num2 = 0;
        Num3 = 0;
    }

    public void VisualUpdate(){
        GetComponent<UIDocument>().gameObject.SetActive(true);
    }

    public void E(){
        if(Num1 == 2 && Num2 == 4 && Num3 == 6){
            EventController.current.LeverTrigger();
        }
    }    
}

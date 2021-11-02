using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUTTON : MonoBehaviour
{
    public Collider ButtonEasy, ButtonMedium, ButtonHard;
    public Collider ThisButton;
    public TargetManger Selector;


    public void OnTriggerEnter(Collider other)
    {
           if (ThisButton == ButtonEasy)
           {
               Selector.buttonSizeSelected = 0;
               Debug.Log("Hit1");
           }

           if (ThisButton == ButtonMedium)
           {
               Selector.buttonSizeSelected = 1; 
               Debug.Log("Hit2");
           }

           if (ThisButton == ButtonHard)
           {
               Selector.buttonSizeSelected = 2; 
               Debug.Log("Hit3");
           }
           Debug.Log("Hit");
    }   



}

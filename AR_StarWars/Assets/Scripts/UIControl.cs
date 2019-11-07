using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public enum eAction
{
    Avancer, Tourner
}

public class UIControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject joueur;
    public eAction action;
    public int direction;
   
    private bool pressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }
 
    void Update()
    {
        if (!pressed)
            return;
 
        switch(action)
        {
            case eAction.Avancer:
                joueur.GetComponent<DeplacementRobot>().Avancer(direction);
                break;
            case eAction.Tourner:
                joueur.GetComponent<DeplacementRobot>().Tourner(direction);
                break;
        }
    }
}

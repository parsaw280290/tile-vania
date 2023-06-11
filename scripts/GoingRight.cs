using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoingRight : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public bool isGoingRight;

    
   
    public void OnPointerDown(PointerEventData data)
    {
        isGoingRight = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isGoingRight = false;
    }
    public bool GetIsGoingRight()
    {
        return isGoingRight;
    }
}

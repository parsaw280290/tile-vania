using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoingLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isGoingLeft;



    public void OnPointerDown(PointerEventData data)
    {
        isGoingLeft = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isGoingLeft = false;
    }
    public bool GetIsGoingLeft()
    {
        return isGoingLeft;
    }
}


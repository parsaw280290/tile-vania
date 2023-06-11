using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoingDown : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isGoingDown;



    public void OnPointerDown(PointerEventData data)
    {
        isGoingDown = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isGoingDown = false;
    }
    public bool GetIsGoingDown()
    {
        return isGoingDown;
    }
}

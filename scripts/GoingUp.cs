using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoingUp : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isGoingUp;



    public void OnPointerDown(PointerEventData data)
    {
        isGoingUp = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isGoingUp = false;
    }
    public bool GetIsGoingUp()
    {
        return isGoingUp;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapHazards : MonoBehaviour
{
    [SerializeField] float verticalScrollRate = 0.2f;
    [SerializeField] float horizantalScrollRAte = 0f;
    bool trapActivator = false;
    void Update()
    {
        if (trapActivator == true)
        {
            transform.Translate(new Vector2(horizantalScrollRAte*Time.deltaTime, verticalScrollRate * Time.deltaTime));
        }
    }
    public bool TrapActivator()
    {
        return trapActivator = true;
    }
}


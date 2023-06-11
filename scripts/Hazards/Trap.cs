using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<TrapHazards>().TrapActivator();
        if (FindObjectOfType<TrapWaterLeft>() != null)
        {
            FindObjectOfType<TrapWaterLeft>().TrapActivatorLeft();
        }
        Destroy(gameObject);
    }
}

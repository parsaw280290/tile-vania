using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterKey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<WaterTrap>().KeyCounter();
        Destroy(gameObject);
    }
}

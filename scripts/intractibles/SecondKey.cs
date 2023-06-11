using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondKey : MonoBehaviour
{
    int key = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        key++;
    }
    private void Update()
    {
        if (key > 0)
        {
            Destroy(GameObject.Find("Door2"));
            Destroy(gameObject);
        }

    }
}

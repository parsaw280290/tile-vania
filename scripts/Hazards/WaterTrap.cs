using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrap : MonoBehaviour
{
    [SerializeField] float scrollRate = 0.2f;
    [SerializeField] float dropRate = 1f;
    int numOfKeys = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (numOfKeys < 3)
        {
        transform.Translate(new Vector2(0f, scrollRate * Time.deltaTime));
        }
        else
        {
            transform.Translate(new Vector2(0f, -dropRate * Time.deltaTime));
        }
    }
    public void KeyCounter()
    {
        numOfKeys++;
    }
}

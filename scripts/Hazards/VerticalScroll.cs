using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScroll : MonoBehaviour
{
    [SerializeField] float verticalScrollRate = 0.2f;
    [SerializeField] float horizantalScrollRate = 0f;
    void Update()
    {
        transform.Translate(new Vector2(horizantalScrollRate*Time.deltaTime, verticalScrollRate * Time.deltaTime));
    }
}

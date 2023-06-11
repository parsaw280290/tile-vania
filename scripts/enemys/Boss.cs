using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] float bossSpeed = 5f;
    
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(bossSpeed, 0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            FindObjectOfType<GameSession>().HealthUp();
            Destroy(gameObject);
        
    }
}

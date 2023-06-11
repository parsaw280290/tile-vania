using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossKiller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(GameObject.Find("Boss (1)"));
        Destroy(gameObject);
    }
}

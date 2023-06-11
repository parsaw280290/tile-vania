using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShreder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(GameObject.Find("Boss"));
    }
}

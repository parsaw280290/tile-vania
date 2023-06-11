using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damge : MonoBehaviour
{
    bool canDamage = false;
    [SerializeField] GameObject deathExplosion;
    [SerializeField] float durationOfExplosion = 1.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<DamgeActivator>())
        {
            CanDamge();
            FindObjectOfType<PickControler>().CanDamage();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.GetComponent<EnemyMovment>() && canDamage) 
        {
            Destroy(collision.gameObject);
            deathExplosion.SetActive(true);
            Invoke("ActiveDelay", 1f);
        }
    }

    private void CanDamge()
    {
        canDamage = true;
    }
    private void ActiveDelay()
    {
        deathExplosion.SetActive(false);
    }
}

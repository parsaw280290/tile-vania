using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickControler : MonoBehaviour
{
    [SerializeField] GameObject redSword;

    bool canDamage = false;
    void Update()
    {
        if (canDamage)
        {
            redSword.SetActive(true);
        }
        else
        {
            redSword.SetActive(false);
        }
    }

    public void CanDamage()
    {
        canDamage = true;
    }
}

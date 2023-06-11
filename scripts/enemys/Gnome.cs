using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gnome : MonoBehaviour
{
    [SerializeField] GameObject axePrefap;
    Vector2 scale;
    void Start()
    {
        scale = transform.localScale;
        Debug.Log(scale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fire()
    {
        Instantiate(axePrefap, transform.position, Quaternion.identity);
    }
    public Vector2 Scale()
    {
        return scale;
    }
}

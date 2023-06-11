using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    float projectielSpeed;
    [SerializeField] float minSpeed = 1f;
    [SerializeField] float maxSpeed = 3f;
    void Start()
    {
        projectielSpeed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        AxeThrow();
        Shred();
    }

    private void AxeThrow()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f,-projectielSpeed);

    }

    private void Shred()
    {
        if (GetComponent<BoxCollider2D>().IsTouchingLayers(LayerMask.GetMask("ground")))
        {
            Destroy(gameObject);
        }
    }
}

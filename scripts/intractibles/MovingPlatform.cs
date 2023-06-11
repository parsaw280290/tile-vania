using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Vector3 movment;
    [SerializeField] float period = 2f;

    Vector3 startingPos;

    [Range(0, 1)]
    [SerializeField] float movmentFactor;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) { return; }
        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2;
        float rawSineWaves = Mathf.Sin(cycles * tau);

        movmentFactor = rawSineWaves / 2f + 0.5f;
        Vector3 offset = movmentFactor * movment;
        transform.position = startingPos + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingMoon : MonoBehaviour
{
    public GameObject planet;

    private float y;
    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = 75.0f;
    }

    void FixedUpdate()
    {
        y += Time.deltaTime * rotationSpeed;
        transform.localRotation = Quaternion.Euler(0, y, 0);  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMethods : MonoBehaviour
{
    [SerializeField] private Vector3 vector1;
    [SerializeField] private Vector3 vector2;
    [SerializeField] private float dotProduct;
    [SerializeField] private Vector3 crossProduct;
    [SerializeField] private float magnitude;
    [SerializeField] private Vector3 normalized;
    void Start()
    {
        vector1 = new Vector3(1, 2, 3);
        vector2 = new Vector3(4, 5, 6);
        dotProduct = Vector3.Dot(vector1, vector2);
        crossProduct = Vector3.Cross(vector1, vector2);
        magnitude = vector1.magnitude;
        normalized = vector1.normalized;
        Debug.Log("Dot Product: " + dotProduct);
        Debug.Log("Cross Product: " + crossProduct);
        Debug.Log("Magnitude: " + magnitude);
        Debug.Log("Normalized: " + normalized);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

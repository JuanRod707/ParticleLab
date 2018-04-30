using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDispose : MonoBehaviour
{
    public float Lifespan;

    void Start()
    {
        Destroy(gameObject, Lifespan);
    }
}

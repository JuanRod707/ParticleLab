using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnContact : MonoBehaviour
{
    public GameObject CollisionEffect;

    private void OnCollisionEnter(Collision other)
    {
        if (CollisionEffect != null)
        {
            Instantiate(CollisionEffect, transform.position, Quaternion.identity);
        }
        
        Destroy(gameObject);
    }
}

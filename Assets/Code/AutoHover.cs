using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AutoHover : MonoBehaviour
{
    public float MinY;
    public float MaxY;
    public float HoverForce;

    private ParticleSystem[] particles;
    private Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        particles = GetComponentsInChildren<ParticleSystem>();
    }
    
    void Update()
    {
        if (transform.position.y > MaxY)
        {
            StopHovering();
        }
        else if (transform.position.y < MinY)
        {
            StartHovering();
        }
    }

    void StopHovering()
    {
        if (particles.First().isPlaying)
        {
            foreach (var p in particles)
            {
                p.Stop();
            }
        }
    }

    void StartHovering()
    {
        body.AddForce(Vector3.up * HoverForce);
        
        if (!particles.First().isPlaying)
        {
            foreach (var p in particles)
            {
                p.Play();
            }
        }
    }
}

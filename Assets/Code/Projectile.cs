using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float MinStartForce;
    public float MaxStartForce;

    private void Start()
    {
        var body = GetComponent<Rigidbody>();
        body.AddForce(transform.forward * Random.Range(MinStartForce, MaxStartForce));
    }
}

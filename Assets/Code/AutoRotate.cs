using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float RotationSpeed;
    public Vector3 RotationVector;

    private void Update()
    {
        transform.Rotate(RotationVector * RotationSpeed);
    }
}

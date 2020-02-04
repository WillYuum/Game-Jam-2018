using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 1;

    private void Update()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }
}
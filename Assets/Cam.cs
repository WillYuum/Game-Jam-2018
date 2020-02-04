using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private const float MIN_Y_ANGLE = 5.0f;
    private const float MAX_Y_ANGLE = 50.0f;

    public Transform target;

    public float distance = 1.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    public float sensitivityX = 2.0f;
    public float sensitivityY = 1.0f;

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X") * sensitivityX;
        currentY += -Input.GetAxis("Mouse Y") * sensitivityY;

        currentY = Mathf.Clamp(currentY, MIN_Y_ANGLE, MAX_Y_ANGLE);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = target.position + rotation * dir;
        transform.LookAt(target.position);
    }
}


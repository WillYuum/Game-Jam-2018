using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMove : MonoBehaviour
{
    private float ranX;
    private float ranY;
    private float ranZ;

    private void Update()
    {
        GetComponent<Rigidbody>().AddForce(Random.Range(-5, 5), 0, Random.Range(-5, 5));
        transform.position = new Vector3(transform.position.x, Random.Range(1, 2), transform.position.z);
    }
}
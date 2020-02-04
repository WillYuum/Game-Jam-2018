using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    Rigidbody rg;
    private float ranX;
    private float ranY;
    private float ranZ;
    public Transform target;

    public int speed = 5;

    private void Jump()
    {
        rg.AddForce(ranX, ranY, ranZ);
    }

    private void Start()
    {
        rg = GetComponent<Rigidbody>();
        ranX = Random.Range(-50, 50);
        ranY = Random.Range(150, 200);
        ranZ = Random.Range(-50, 50);
        Jump();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            ranX = Random.Range(-50, 50);
            ranY = Random.Range(150, 200);
            ranZ = Random.Range(-50, 50);
            Jump();
        }
    }

    private void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
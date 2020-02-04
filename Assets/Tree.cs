using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tree"))
        {
            Destroy(collision.gameObject);
            GameObject explosionClone = (GameObject)Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
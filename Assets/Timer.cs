using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time = 30;

    private void Update()
    {
        GetComponent<GUIText>().text = time.ToString();
    }
}

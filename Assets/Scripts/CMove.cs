using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.up * 2.0f * Time.deltaTime;
    }
}

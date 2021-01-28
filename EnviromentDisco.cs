using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentDisco : MonoBehaviour
{
    [SerializeField]
    float change=0.2f;
    [SerializeField]
    float time = 0.5f;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 
            Mathf.PingPong(Time.time, time)- change, transform.position.z);
    }
}

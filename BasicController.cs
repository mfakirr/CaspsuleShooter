using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (Input.GetMouseButton(0))
            {
               
                Debug.Log(Input.GetAxis("Horizontal") + "  " + Input.GetAxis("Vertical"));
            }
        }
       
    }
}

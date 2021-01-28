using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicsTargetMover : MonoBehaviour
{
    public float spinSpeed=180.0f;
    public float motionMagnitude = 0.1f;

    public bool doSpin=true;
    public bool doMotion = false;
    void Update()
    {
        //rotate
        if (doSpin)
        {
            gameObject.transform.Rotate(Vector3.up *
                        spinSpeed * Time.deltaTime);
        }

        //move
        if (doMotion)
        {
            gameObject.transform.Translate(Vector3.up *
            Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
        
        //

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public float spin_Speed = 180.0f;
    public float motion_Speed = 0.1f;

    public bool doSpin = true;
    public bool doMotion = false;

    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            //spin the object
            gameObject.transform.Rotate(Vector3.up * spin_Speed * Time.deltaTime);
        }

        if (doMotion)
        {
            //move up and down
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motion_Speed);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public int rotationSpeed = 20;
    public Quaternion direction;
    float smooth = 5.0f;
    float tiltAngle = 90.0f;
    public Quaternion target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            target = Quaternion.Euler(0, 90, 0);
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSpeed);
        //// Smoothly tilts a transform towards a target rotation.
        //float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
        //float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        //Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, 0);

        // Dampen towards the target rotation
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}

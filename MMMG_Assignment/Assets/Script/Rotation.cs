using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public int rotationSpeed = 10;
    //float smooth = 5.0f;
    //float tiltAngle = 90.0f;
    public Quaternion target;
    public int yRotation;

    private void OnMouseDown()
    {
        yRotation += 90; //importatn
        target = Quaternion.Euler(0, yRotation, 0); //important
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSpeed);

    }

    //void TouchCube()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit hit;

    //    if (Physics.Raycast(ray, out hit))
    //    {
    //        if (hit.transform.name == "Cube")
    //        {
    //            yRotation += 90; //importatn
    //            target = Quaternion.Euler(0, yRotation, 0); //important

    //        }
    //        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSpeed);
    //        Debug.Log("Cube hit");
    //    }
    //    transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSpeed); //important
    //}

    void Update()
    {

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSpeed);
        //TouchCube();
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    target = Quaternion.Euler(0, , 0);
        //}

        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSpeed);
        //target = transform.rotation;

        //// Smoothly tilts a transform towards a target rotation.
        //float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
        //float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        //Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, 0);

        // Dampen towards the target rotation
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}


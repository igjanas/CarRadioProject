using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target; // The object to orbit around
    public float distance = 5.0f; // Distance from the target object
    public float xSpeed = 120.0f; // Speed of rotation around the x-axis
    public float ySpeed = 120.0f; // Speed of rotation around the y-axis

    private float x = 0.0f;
    private float y = 0.0f;

    void Start()
    {
        // Initialize the rotation angles based on the current rotation of the camera
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
    }

    void LateUpdate()
    {
        if (target)
        {
            if (Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    // Calculate the rotation from the touch delta position
                    x += touch.deltaPosition.x * xSpeed * 0.02f;
                    y -= touch.deltaPosition.y * ySpeed * 0.02f;
                }
            }

            // Clamp the vertical angle within a range
            y = Mathf.Clamp(y, -20, 80);

            // Convert the angles into a rotation
            Quaternion rotation = Quaternion.Euler(y, x, 0);

            // Calculate the position based on the distance and rotation
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;

            // Update the camera's position and rotation
            transform.rotation = rotation;
            transform.position = position;
        }
    }
}
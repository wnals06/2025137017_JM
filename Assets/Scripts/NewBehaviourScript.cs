using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    void LateUpdate()
    {
        Vector3 desiredPosition = new Vector3(
            Mathf.Clamp(target.position.x, minPosition.x, maxPosition.x),
            Mathf.Clamp(target.position.y, minPosition.y, maxPosition.y),
            transform.position.z);

        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float sideLimits = 10.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && (transform.position.x >= -sideLimits))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
        }

        if (Input.GetKey(KeyCode.D) && (transform.position.x <= sideLimits))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
        }
    }
}

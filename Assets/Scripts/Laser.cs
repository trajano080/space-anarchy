using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float laserSpeed = 10.0f;
    private float laserLimit = 87.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * laserSpeed, Space.World);

        if (transform.position.z >= laserLimit)
        {
            Destroy(gameObject);
        }
    }
}

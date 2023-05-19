using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidsBehaviour : MonoBehaviour
{
    public float asteroidSpeed = 1.5f;
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * asteroidSpeed, Space.World);
    }
}

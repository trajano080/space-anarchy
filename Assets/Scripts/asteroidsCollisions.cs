using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidsCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}

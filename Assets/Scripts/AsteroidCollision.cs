using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    public Asteroids asteroids;
    void OnTriggerEnter(Collider other)
    {
        asteroids.collision();
    }
}

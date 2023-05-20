using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    public Asteroids asteroids;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            asteroids.playerCollision();
        }
        else if (other.gameObject.tag == "Laser")
        {
            Destroy(other.gameObject);
            asteroids.laserCollision();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public GameObject asteroid;

    public Player player;
    private float asteroidSpeed = 15f;
    private float asteroidLimit = 6.0f;
    public Vector3 position0 = new Vector3(0.0f, 1.0f, 40.0f);

    void Start()
    {
        position0.x = (float)UnityEngine.Random.Range(-player.sideLimits, player.sideLimits);
        asteroid.transform.Translate(position0);
    }

    void Update()
    {
        asteroid.transform.Translate(Vector3.back * Time.deltaTime * asteroidSpeed, Space.World);
        if (asteroid.transform.position.z <= -asteroidLimit)
        {
            changeAsteroid();
        }

    }

    void changeAsteroid()
    {
        position0.x = (float)UnityEngine.Random.Range(-player.sideLimits, player.sideLimits);
        asteroid.transform.position = position0;
        asteroid.transform.Rotate(Vector3.right, (float)UnityEngine.Random.Range(0, 90));
        asteroid.transform.Rotate(Vector3.up, (float)UnityEngine.Random.Range(0, 90));
        asteroid.transform.Rotate(Vector3.forward, (float)UnityEngine.Random.Range(0, 90));
        asteroid.gameObject.SetActive(true);
    }

    public void playerCollision()
    {
        player.loseLife();
        changeAsteroid();
    }

    public void laserCollision()
    {
        player.addScore();
        changeAsteroid();
    }
}

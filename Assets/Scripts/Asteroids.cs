using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject explosion;
    private ParticleSystem.ColorOverLifetimeModule explotionColor;
    private Gradient explosionGradient;
    public Player player;
    private float asteroidSpeed = 15f;
    private float asteroidLimit = 6.0f;
    public Vector3 position0 = new Vector3(0.0f, 1.0f, 40.0f);

    void Start()
    {
        position0.x = (float)UnityEngine.Random.Range(-player.sideLimits, player.sideLimits);
        asteroid.transform.Translate(position0);

        explotionColor = explosion.GetComponent<ParticleSystem>().colorOverLifetime;
        explosionGradient = explosion.GetComponent<ParticleSystem>().colorOverLifetime.color.gradient;
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
    }

    void playExplosion()
    {
        explosion.transform.position = asteroid.transform.position;
        explosion.transform.rotation = asteroid.transform.rotation;
        explosion.GetComponent<ParticleSystem>().Play();
    }

    public void playerCollision()
    {
        player.loseLife();
        explotionColor.color = explosionGradient.colorKeys[0].color;
        playExplosion();
        changeAsteroid();
    }

    public void laserCollision()
    {
        player.addScore();
        explotionColor.color = explosionGradient.colorKeys[1].color;
        playExplosion();
        changeAsteroid();
    }
}

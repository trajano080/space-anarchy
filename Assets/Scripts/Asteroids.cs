using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public GameObject[] asteroidsArray = new GameObject[3];
    public Player player;
    private float asteroidSpeed = 10f;
    private float asteroidLimit = 6.0f;
    public Vector3 position0 = new Vector3(0.0f, 1.0f, 40.0f);

    private GameObject asteroid;
    void Start()
    {
        asteroid = asteroidsArray[0];
        asteroidsArray[1].SetActive(false);
        asteroidsArray[2].SetActive(false);

        position0.x = (float)UnityEngine.Random.Range(-player.sideLimits, player.sideLimits);
        asteroid.transform.Translate(position0);
    }

    void Update()
    {
        asteroid.transform.Translate(Vector3.back * Time.deltaTime * asteroidSpeed, Space.World);
        if (asteroid.transform.position.z <= -asteroidLimit)
        {
            player.addScore();
            changeAsteroid();
        }

    }

    void changeAsteroid()
    {
        position0.x = (float)UnityEngine.Random.Range(-player.sideLimits, player.sideLimits);
        asteroid.SetActive(false);
        asteroid = asteroidsArray[UnityEngine.Random.Range(0, 3)];
        asteroid.gameObject.SetActive(true);
        asteroid.transform.position = position0;
    }

    public void collision()
    {
        player.loseLife();
        changeAsteroid();
    }
}

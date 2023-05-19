using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Player player;
    private float asteroidSpeed = 10f;
    private float asteroidLimit = 6.0f;
    public Vector3 position0 = new Vector3(0.0f, 1.0f, 40.0f);
    void Start()
    {
        position0.x = (float)UnityEngine.Random.Range(-player.sideLimits, player.sideLimits);
        transform.Translate(position0);
    }
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * asteroidSpeed, Space.World);
        if (transform.position.z <= -asteroidLimit)
        {
            position0.x = (float)UnityEngine.Random.Range(-player.sideLimits, player.sideLimits);
            transform.position = position0;
            player.addScore();
        }

    }

    void OnTriggerEnter(Collider other)
    {
        player.loseLife();
        transform.position = position0;
    }
}

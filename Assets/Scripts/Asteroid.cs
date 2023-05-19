using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Player player;
    private float asteroidSpeed = 10f;
    private float asteroidLimit = 6.0f;
    private Vector3 position0 = new Vector3(0.0f, 1.0f, 40.0f);
    void Start()
    {
        transform.Translate(position0);
    }
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * asteroidSpeed, Space.World);
        if (transform.position.z <= -asteroidLimit)
        {
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

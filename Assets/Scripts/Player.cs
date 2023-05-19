using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    /* GAME'S FEATURES */
    public float moveSpeed = 10.0f;
    public float sideLimits = 5.0f;
    public TextMeshProUGUI text;

    /* PLAYER'S FEATURES */
    public GameObject laser;

    private int initialLives = 3;
    private static int score;
    private static int currentLives;

    void Start()
    {
        currentLives = initialLives;
        score = 0;
    }

    void Update()
    {
        /* PLAYER'S CONTROLS */
        if (Input.GetKey(KeyCode.A) && (transform.position.x >= -sideLimits))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
        }

        if (Input.GetKey(KeyCode.D) && (transform.position.x <= sideLimits))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
        }

        /* PLAYER'S LASER */
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newlaser = Instantiate(laser);
            newlaser.transform.position = transform.position;
            newlaser.AddComponent<Laser>();
        }

        /* PLAYER'S LOSE CONDITION */
        text.GetComponentInChildren<TextMeshProUGUI>().text = "Score: " + score + " / Lives: " + currentLives;
        if (currentLives <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void loseLife()
    {
        currentLives -= 1;
    }

    public void addScore()
    {
        score += 1;
    }
}

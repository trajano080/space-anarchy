using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private int initialLives = 3;
    private static int currentLives;

    private static int score;
    public TextMeshProUGUI text;
    void Start()
    {
        currentLives = initialLives;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
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

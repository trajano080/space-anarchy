using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class payerFeatures : MonoBehaviour
{
    public int initialLives = 3;

    public int currentLives;
    public TextMeshProUGUI textLives;
    void Start()
    {
        currentLives = initialLives;
    }

    // Update is called once per frame
    void Update()
    {
        textLives.GetComponentInChildren<TextMeshProUGUI>().text = "Lives: " + currentLives;
        if (currentLives <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        currentLives -= 1;
    }
}

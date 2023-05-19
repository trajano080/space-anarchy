using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class payerFeatures : MonoBehaviour
{
    public int initialLives = 3;

    public int currentLives;
    void Start()
    {
        currentLives = initialLives;
    }

    // Update is called once per frame
    void Update()
    {
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

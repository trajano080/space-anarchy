using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Scoreboard : MonoBehaviour
{

    public TMP_Text[] users = new TMP_Text[StaticVariables.scores.Count];
    public TMP_Text[] scores = new TMP_Text[StaticVariables.scores.Count];

    void Start()
    {
        int i = 0;
        foreach (KeyValuePair<string, int> score in StaticVariables.scores)
        {
            users[i].text = score.Key;
            scores[i].text = score.Value.ToString();
            i += 1;
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}

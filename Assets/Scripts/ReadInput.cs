using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ReadInput : MonoBehaviour
{
    public TMP_Text warning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string input)
    {
        StaticVariables.activeUser = input;
        if (!(StaticVariables.scores.ContainsKey(input)))
        {
            if (StaticVariables.scores.Count == 6)
            {
                warning.text = "User limit reached - can not add new user. Please enter an existing username.";
                return;
            }
            StaticVariables.scores.Add(input, 0);
        }
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public TMP_Text username;
    public TMP_Text highscore;
    void Start()
    {
        if (StaticVariables.scores.Count < 1)
        {
            SceneManager.LoadScene(3);
        }

        /*
        StaticVariables.scores = new List<int>();
        StaticVariables.users = new List<string>();
        StaticVariables.users.Add("Player");
        StaticVariables.activeUser = "Player";
        */
    }
    void Update()
    {
        username.text = "User: " + StaticVariables.activeUser;
        highscore.text = "Highscore: " + StaticVariables.scores[StaticVariables.activeUser].ToString();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeUser()
    {
        SceneManager.LoadScene(3);
    }
    public void viewScore()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

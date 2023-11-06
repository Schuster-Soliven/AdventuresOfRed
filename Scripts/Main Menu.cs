using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void LevelOne () {
        Debug.Log("Going to Level 1");
        SceneManager.LoadScene("Level 1-AoR");
    }
    public void LevelTwo () {
        Debug.Log("Going to Level 2");
        SceneManager.LoadScene("Level 2-AoR");
    }
    public void LevelThree () {
        Debug.Log("Going to Level 3");
        SceneManager.LoadScene("Level 3-AoR");
    }
    public void Settings () {
        Debug.Log("Going to Settinngs");
        SceneManager.LoadScene("Settings");
    }

    public void Death () {
        Debug.Log("Going to Settinngs");
        SceneManager.LoadScene("Death");
    }

    public void QuitGame () {
        Debug.Log("Quit");
        Application.Quit();
    }
}

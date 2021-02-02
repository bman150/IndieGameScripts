using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    // Starts the game at level 1.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Display game instructions and story.

    // Quits the game
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}

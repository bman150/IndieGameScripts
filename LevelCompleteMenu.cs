using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMenu : MonoBehaviour {
    public static bool LevelIsCompleted = false;
    public GameObject levelCompletedMenuUI; // References the level complete menu UI.

    // Update is called once per frame
    void Update() {
        if (LevelIsCompleted)
        {
            levelCompletedMenuUI.SetActive(true);
        }
        else
        {
            levelCompletedMenuUI.SetActive(false);
        }
    }

    // Starts the player on the next level.
    public void LoadNextLevel() {
        Debug.Log("Loading the next stage");
        LevelIsCompleted = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // loads the next level.
    }

    // returns player to the main menu
    public void LoadMainMenu() {
        Debug.Log("Loading main menu...");
        LevelIsCompleted = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // MAY NEED TO EDIT THIS CODE FOR ADDITIONAL LEVELS.
    }

    // quits the game
    public void QuitGame() {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

}

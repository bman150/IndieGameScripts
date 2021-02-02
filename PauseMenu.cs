using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; // References the pause menu UI.


    // Update is called once per frame
    void Update () {

        // pause menu displays/hides when escape key is pressed.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    // Resumes game play and disables(hides) pause menu.
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // unfreezes game play
        GameIsPaused = false;
        AudioListener.pause = false; // Unmutes all sounds.
        FindObjectOfType<GameManager>().PauseGame();
    }

    // Enables pause menu
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // freezes game play
        GameIsPaused = true;
        AudioListener.pause = true; // Mutes all sounds.
        FindObjectOfType<GameManager>().PauseGame();
    }

    public void LoadMainMenu()
    {
        Debug.Log("Loading main menu...");
        Time.timeScale = 1f;
        AudioListener.pause = false; // makes sure that audio is not muted when player returns to main menu.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    bool levelHasEnded = false;

    // Use this for initialization
    void Start() {
        // hides and locks mouse cursor at start of each level.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // displays the game over menu whenever the player character collides with a trap object.
    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Cursor.lockState = CursorLockMode.None; // unlock mouse cursor
            Cursor.visible = true; // unhide mouse cursor
            GameObject stopCamera = GameObject.FindGameObjectWithTag("MainCamera");
            stopCamera.GetComponent<FollowPlayer>().enabled = false; // disable player camera movement
            Debug.Log("GAME OVER");
            GameOverMenu.PlayerIsDead = true; // Display game over menu
        }
    }

    // displays the level completed menu whenever the player character collides with a win level object.
    public void EndLevel() {
        if (levelHasEnded == false)
        {
            levelHasEnded = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            GameObject stopCamera = GameObject.FindGameObjectWithTag("MainCamera");
            stopCamera.GetComponent<FollowPlayer>().enabled = false;
            Debug.Log("LEVEL COMPLETED");
            LevelCompleteMenu.LevelIsCompleted = true; // Display the level completed menu
        }
    }

    // unhides mouse cursor and disables camera movement when game is paused.
    public void PauseGame() {
        if (PauseMenu.GameIsPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            GameObject stopCamera = GameObject.FindGameObjectWithTag("MainCamera");
            stopCamera.GetComponent<FollowPlayer>().enabled = false; // disable player camera movement
        }
        else {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            GameObject resumeCamera = GameObject.FindGameObjectWithTag("MainCamera");
            resumeCamera.GetComponent<FollowPlayer>().enabled = true; // enable player camera movement
        }
    }

}

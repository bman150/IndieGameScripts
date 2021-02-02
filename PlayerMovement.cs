using UnityEngine;

// Controlls the player characters movement.
public class PlayerMovement : MonoBehaviour {

    public float playerMoveSpeed = 10f; // Set player characters movement speed to 10.

	// Use this for initialization
	void Start () {
        Debug.Log("Hello world!");
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * playerMoveSpeed; // Set forward/backward movement
        float straffe = Input.GetAxis("Horizontal") * playerMoveSpeed; // Set left/right movement.

        translation *= Time.deltaTime; // Set forward/backward movement rate to real time in seconds.
        straffe *= Time.deltaTime; // Set left/right movement rate to real time in seconds.

        // Prevent player character from moving up/down along the y-axis.
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            FindObjectOfType<AudioManager>().Play("PlayerFootsteps"); // Enable walking sound effect.
        }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            FindObjectOfType<AudioManager>().Stop("PlayerFootsteps"); // Disable walking sound effect.
        }


	}
}

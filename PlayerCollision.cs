using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement; // A reference to PlayerMovement script.

    private Animation fallover; // a reference to the player characters death animation

    // This function runs when player character collides with an object with specific tags.
    //void OnCollisionEnter(Collision collisionInfo) {

        //if (collisionInfo.collider.tag == "Trap")
        //{
            //movement.enabled = false; // Disable the players movement.
            //collisionInfo.gameObject.SetActive(false);// Hide the trap object.
            //collisionInfo.gameObject.GetComponent<ParticleSystem>().Play();// play explosion effect
            //FindObjectOfType<AudioManager>().Stop("PlayerFootsteps"); // stops any lingering footstep sounds from looping after player characters death.
            //FindObjectOfType<AudioManager>().Play("PlayerDeath"); // plays the explosion caused by a "Trap"
            //FindObjectOfType<GameManager>().EndGame();
        //}
        //if (collisionInfo.collider.tag == "WinLevel") {
            //movement.enabled = false;
            //collisionInfo.gameObject.SetActive(false); // hide the trigger object.
            //FindObjectOfType<AudioManager>().Stop("PlayerFootsteps");
            //FindObjectOfType<AudioManager>().Play("Warp");
            //FindObjectOfType<GameManager>().EndLevel();
        //}

    //}
    // This function runs when player character collides with a trigger/object with specific tags.
    private void OnTriggerEnter(Collider other)
    {
        // if player collides into a trap
        if (other.gameObject.tag == "Trap")
        {
            movement.enabled = false;
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<ParticleSystem>().Play();
            FindObjectOfType<AudioManager>().Stop("PlayerFootsteps");
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            FindObjectOfType<GameManager>().EndGame();
        }
        // if player collides into the win trigger
        if (other.gameObject.tag == "WinLevel")
        {
            movement.enabled = false;
            other.gameObject.SetActive(false); // hide the trigger object.
            FindObjectOfType<AudioManager>().Stop("PlayerFootsteps");
            FindObjectOfType<AudioManager>().Play("Warp");
            FindObjectOfType<GameManager>().EndLevel();
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooranimator : MonoBehaviour {


    private Animation doormanager; // stores the trapdoor opening animation
    bool open = false;//flag to check whether the door needs closing


    // Use this for initialization
    void Start () {
        doormanager = GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider Col)//play animation if player is near
    {
        if (Col.gameObject.tag == "Player")
        {
            open = true;
            doormanager.Play("undooropen");
            FindObjectOfType<AudioManager>().Play("SliddingDoor");
        }
    }

    
    void OnTriggerExit(Collider Col)// if the player moves away, close the door
    {
        if (Col.gameObject.tag == "Player" && open == true)
        {
            doormanager.Play("undoorclose");
            FindObjectOfType<AudioManager>().Play("SliddingDoor");
        }
    }


}

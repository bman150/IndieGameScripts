using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallfix : MonoBehaviour {
    private GameAndPlayer playerref;
    [SerializeField]
    private float minheight;
	// Use this for initialization
	void Start () {
        playerref = GetComponent<GameAndPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < minheight)
        {

            playerref.loseCount += 1;
            playerref.SetLoseCount();
        }
	}
}

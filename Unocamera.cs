using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unocamera : MonoBehaviour {

    public Vector2 mouseLook; //Will keep track of how much movement the camera has made.
    public Vector2 smoothV; //Helps to smooth down the movement of the mouse.
    public float sensitivity = 5.0f; //The level of sensitivity of the mouse movement.
    public float smoothing = 2.0f; //The level of smoothness of the mouse movement.
    GameObject character; //A game object will be linked to "character" to make mouse movement move the linked object as well.

    // Use this for initialization
    void Start()
    {
        character = this.transform.parent.transform.parent.gameObject; //Sets "character" to parent object that the camera is a child of.
    }

    // Update is called once per frame
    void Update()
    {
        //var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")); //Sets the directions the mouse can move on(2D x and y-axis).
        //md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing)); //Sets how sensitivity and smoothing together effect the mouse movement.
        //smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing); //Sets the smoothing for mouses x-axis direction(2D axis).
        //smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing); //Sets the smoothing for mouses y-axis direction(2D axis).
        //mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f); //Limits the up and down movement angle of mouse to 90 degrees.
        //mouseLook += smoothV; //Adds smoothV to mouseLook (and all that smoothV is programed with in previous lines above?).
        //transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right); //Applys mouseLook's y-axis(2D) movement to the right axis of the camera(3D axis).
        //character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up); //Applys mouseLook's x-axis(2D) movement to the up axis of the camera(3D).
    }
}

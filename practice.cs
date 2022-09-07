using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice : MonoBehaviour
{
 
      //create a top down movement script for a rigidbody that points towards the mouse pointer
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position
        Vector3 mousePos = Input.mousePosition;
        //convert the mouse position to world space
        Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);
        //get the direction from the player to the mouse
        Vector3 direction = mousePosWorld - transform.position;
        //set the rotation of the player to the direction
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
        //move the player
        transform.Translate(Vector3.up * Time.deltaTime * 5);
    }
}
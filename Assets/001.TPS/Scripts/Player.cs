using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Private camera
    private GameObject cameraPivot;
    // Mouse speed
    private float mouseSpeed = 100f;
    // Movement speed
    private float movementSpeed = 30f;

    // Use this for initialization
    void Start ()
    {
        // Find the object camera pivot
        foreach (Transform child in gameObject.transform)
        {
            if (child.CompareTag("CameraPivot"))
            {

                cameraPivot = child.gameObject;
                break;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        // Camera control
        gameObject.transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * mouseSpeed);
        cameraPivot.transform.Rotate(new Vector3(- Input.GetAxis("Mouse Y"), 0, 0) * Time.deltaTime * mouseSpeed);
        // Movement
        if (Input.GetKey(KeyCode.W)) {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(- Vector3.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }
    }
}

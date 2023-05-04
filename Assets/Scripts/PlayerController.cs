using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 12.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    public string inputID;
    //Use it for to change the camera Input.GetKeyDown(switchKey)
    //public KeyCode switchKey;
/* Also we can apply something like this:
    mainCamera.enabled = !mainCamera.enabled;
    hoodCamera.enabled = !hoodCamera.enabled;*/

// Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
    void Update()
    {
        //Input player
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        //Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
     //   transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        //Rotates the car based on horizontal Input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public string inputID;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move vehicle forward
        //Gets Forward and Backward Inputs
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        //Gets Right and Left Inputs
        forwardInput = Input.GetAxis("Vertical" + inputID);
        //Moves car to the front based on player input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Moves car to the left and right based on player input and rotates car with movement
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}

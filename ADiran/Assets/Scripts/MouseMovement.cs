using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    //variables
    public float sensitivity = 100f; //how fast the camera moves in game
    public Transform playerBody; //declaring then camera movement variable

    float xRotation = 0f; //mouse rotation
    

    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //makes the cursor so it is locked into the centre of the camera
        GetComponent<Interactions>();
    }

    // Update is called once per frame
    void Update()
    {
        //takes input data from mouse and turns it into values I can use
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY; //makes it so the y axis is not inverted
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //limits camera movement so you cant do a 360 on the y axis

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //takes the values from the mouse and makes the camera turn
        playerBody.Rotate(Vector3.up * mouseX); // makes it so the playerbody turns left and right when you move the mouse on the x axis

        
    }

   

}

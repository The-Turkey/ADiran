using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public float interactionRange = 3f;//how far out the ray goes
    public Camera fpsCam; //declaring the camera
    private bool ButtonClicked = false; //declaring whenther or not the button has been clicked
    private int buttonClickTimes;

    public GameObject yellowBall; //declaring the yellow ball object
    public GameObject redBall; //declaring the red ball object
    private bool RedYellowBall = true; // the boolean that decided whether a yellow or a red ball falls down(true means red)
    private bool buttonState = true;//boolean to determine whether or not the button can be clicked

    private int buttonClickTimes_7;

    ButtonClick Button1;
    ButtonClick7 Button2;

    // Start is called before the first frame updates
    void Start()
    {
        Button1 = GameObject.FindGameObjectWithTag("Button").GetComponent<ButtonClick>();//declared the animation script
        Button2 = GameObject.FindGameObjectWithTag("button 7").GetComponent<ButtonClick7>();//declared the animation script for the button in column 7
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) //when click left mouse button
        {
            Interaction();
        }

        

    }

    void Interaction()
    {
        int layerMask = 1 << 7;//makes it so the raycast only detects the button
        int layerMask_7 = 1 << 10;
        RaycastHit hit;

        if (buttonState == true)
        {

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

                /*if (hit.transform.gameObject.CompareTag("Button"))
                {
                    a.PressButton();
                }*/



                if (buttonClickTimes < 6)//if button has been clicked less than 7 times
                {
                    if (RedYellowBall == true)
                    {
                        Button1.PressButton();//calls in the animation script for the button
                        Instantiate(redBall);//creates red ball
                        RedYellowBall = false;// next turn is yellow ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }
                    else
                    {
                        Button1.PressButton();//calls in the animation script for the button
                        Instantiate(yellowBall);//creates yellow ball
                        RedYellowBall = true;//next turn is red ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }

                    buttonClickTimes = buttonClickTimes + 1;//button has now been clicked one more time
                }
            }

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask_7)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

                /*if (hit.transform.gameObject.CompareTag("Button"))
                {
                    a.PressButton();
                }*/



                if (buttonClickTimes_7 < 6)//if button has been clicked less than 7 times
                {
                    if (RedYellowBall == true)
                    {
                        Button2.PressButton();//calls in the animation script for the button
                        Instantiate(redBall, new Vector3(6f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates red ball
                        RedYellowBall = false;// next turn is yellow ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }
                    else
                    {
                        Button2.PressButton();//calls in the animation script for the button
                        Instantiate(yellowBall, new Vector3(6f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates yellow ball
                        RedYellowBall = true;//next turn is red ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }

                    buttonClickTimes_7 = buttonClickTimes_7 + 1;//button has now been clicked one more time
                }
            }
        }
    }
    //re-enables the ability to click the button
    void enableButton()
    {
        buttonState = true;
    }
}


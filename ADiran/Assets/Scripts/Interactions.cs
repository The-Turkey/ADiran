using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public float interactionRange = 3f;//how far out the ray goes
    public Camera fpsCam; //declaring the camera

    public GameObject yellowBall; //declaring the yellow ball object
    public GameObject redBall; //declaring the red ball object
    private bool RedYellowBall = true; // the boolean that decided whether a yellow or a red ball falls down(true means red)
    private bool buttonState = true;//boolean to determine whether or not the button can be clicked

    private int buttonClickTimes; //int for how many times button has been clicked
    private int buttonClickTimes_2;
    private int buttonClickTimes_3;
    private int buttonClickTimes_4;
    private int buttonClickTimes_5;
    private int buttonClickTimes_6;
    private int buttonClickTimes_7;

    ButtonClick Button1;
    ButtonClick2 Button2;
    ButtonClick3 Button3;
    ButtonClick4 Button4;
    ButtonClick5 Button5;
    ButtonClick6 Button6;
    ButtonClick7 Button7;


    // Start is called before the first frame updates
    void Start()
    {
        Button1 = GameObject.FindGameObjectWithTag("Button").GetComponent<ButtonClick>();//declared the animation script
        Button2 = GameObject.FindGameObjectWithTag("Button 2").GetComponent<ButtonClick2>();
        Button3 = GameObject.FindGameObjectWithTag("Button 3").GetComponent<ButtonClick3>();
        Button4 = GameObject.FindGameObjectWithTag("Button 4").GetComponent<ButtonClick4>();
        Button5 = GameObject.FindGameObjectWithTag("Button 5").GetComponent<ButtonClick5>();
        Button6 = GameObject.FindGameObjectWithTag("Button 6").GetComponent<ButtonClick6>();
        Button7 = GameObject.FindGameObjectWithTag("button 7").GetComponent<ButtonClick7>();//declared the animation script for the button in column 7
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
        int layerMask_2 = 1 << 11;
        int layerMask_3 = 1 << 12;
        int layerMask_4 = 1 << 13;
        int layerMask_5 = 1 << 14;
        int layerMask_6 = 1 << 15;

        RaycastHit hit;

        if (buttonState == true)
        {

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

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

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask_2)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

                if (buttonClickTimes_2 < 6)//if button has been clicked less than 7 times
                {
                    if (RedYellowBall == true)
                    {
                        Button2.PressButton();//calls in the animation script for the button
                        Instantiate(redBall, new Vector3(1f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates red ball
                        RedYellowBall = false;// next turn is yellow ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }
                    else
                    {
                        Button2.PressButton();//calls in the animation script for the button
                        Instantiate(yellowBall, new Vector3(1f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates yellow ball
                        RedYellowBall = true;//next turn is red ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }

                    buttonClickTimes_2 = buttonClickTimes_2 + 1;//button has now been clicked one more time
                }
            }

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask_3)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

                if (buttonClickTimes_3 < 6)//if button has been clicked less than 7 times
                {
                    if (RedYellowBall == true)
                    {
                        Button3.PressButton();//calls in the animation script for the button
                        Instantiate(redBall, new Vector3(2f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates red ball
                        RedYellowBall = false;// next turn is yellow ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }
                    else
                    {
                        Button3.PressButton();//calls in the animation script for the button
                        Instantiate(yellowBall, new Vector3(2f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates yellow ball
                        RedYellowBall = true;//next turn is red ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }

                    buttonClickTimes_3 = buttonClickTimes_3 + 1;//button has now been clicked one more time
                }
            }

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask_4)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

                if (buttonClickTimes_4 < 6)//if button has been clicked less than 7 times
                {
                    if (RedYellowBall == true)
                    {
                        Button4.PressButton();//calls in the animation script for the button
                        Instantiate(redBall, new Vector3(3f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates red ball
                        RedYellowBall = false;// next turn is yellow ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }
                    else
                    {
                        Button4.PressButton();//calls in the animation script for the button
                        Instantiate(yellowBall, new Vector3(3f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates yellow ball
                        RedYellowBall = true;//next turn is red ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }

                    buttonClickTimes_4 = buttonClickTimes_4 + 1;//button has now been clicked one more time
                }
            }

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask_5)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

                if (buttonClickTimes_5 < 6)//if button has been clicked less than 7 times
                {
                    if (RedYellowBall == true)
                    {
                        Button5.PressButton();//calls in the animation script for the button
                        Instantiate(redBall, new Vector3(4f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates red ball
                        RedYellowBall = false;// next turn is yellow ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }
                    else
                    {
                        Button5.PressButton();//calls in the animation script for the button
                        Instantiate(yellowBall, new Vector3(4f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates yellow ball
                        RedYellowBall = true;//next turn is red ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }

                    buttonClickTimes_5 = buttonClickTimes_5 + 1;//button has now been clicked one more time
                }
            }

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask_6)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

                if (buttonClickTimes_6 < 6)//if button has been clicked less than 7 times
                {
                    if (RedYellowBall == true)
                    {
                        Button6.PressButton();//calls in the animation script for the button
                        Instantiate(redBall, new Vector3(5f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates red ball
                        RedYellowBall = false;// next turn is yellow ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }
                    else
                    {
                        Button6.PressButton();//calls in the animation script for the button
                        Instantiate(yellowBall, new Vector3(5f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates yellow ball
                        RedYellowBall = true;//next turn is red ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }

                    buttonClickTimes_6 = buttonClickTimes_6 + 1;//button has now been clicked one more time
                }
            }

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactionRange, layerMask_7)) //takes the position of the camera and outputs a ray
            {
                //Debug.Log(hit.transform.name); //outputs what object has been hit onto the console

                if (buttonClickTimes_7 < 6)//if button has been clicked less than 7 times
                {
                    if (RedYellowBall == true)
                    {
                        Button7.PressButton();//calls in the animation script for the button
                        Instantiate(redBall, new Vector3(6f, 10f, 10f), Quaternion.Euler(0f, 0f, 0f));//creates red ball
                        RedYellowBall = false;// next turn is yellow ball
                        buttonState = false;//disables button
                        Invoke("enableButton", 2.0f);// after 2 seconds, re-enable button
                    }
                    else
                    {
                        Button7.PressButton();//calls in the animation script for the button
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YellowWinCheck : MonoBehaviour
{
    public GameObject YellowBall;

    public bool hasCollided = false;

    int winTimes = 0;

    turnIndicator turn;

    // Start is called before the first frame update
    void Start()
    {
        turn = GameObject.FindGameObjectWithTag("TurnIndicator").GetComponent<turnIndicator>();
    }

    // Update is called once per frame
    void Update()
    {
        winConditions();
    }

    void winConditions()
    {
        float winCheckRange = 3.1f;//declares the range of the raycast

        int layerMask = 1 << 9;//means the raycast is only able to hit the yellow balls 

        RaycastHit[] hits;//creates an array for whatever the raycast collides with

        hits = null;//empties the array 

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(Vector3.down), winCheckRange, layerMask); //shoots a ray downwards and puts whatever the raycast collides with into the array

        if (hits.Length >= 3)//when the array has collided with 3 or more yellow balls yellow wins 
        {
            yellowWin();
            Debug.Log("yellow down win");
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(Vector3.left), winCheckRange, layerMask); //shoots a ray left and puts whatever the raycast collides with into the array

        if (hits.Length >= 3)//when the array has collided with 3 or more yellow balls yellow wins 
        {
            yellowWin();
            Debug.Log("yellow left win");
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(Vector3.right), winCheckRange, layerMask); //shoots a ray right and puts whatever the raycast collides with into the array

        if (hits.Length >= 3)//when the array has collided with 3 or more yellow balls yellow wins 
        {
            yellowWin();
            Debug.Log("yellow right win");
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(1f, 1f, 0f), 4.24f, layerMask); //shoots a ray diagonally up right and puts whatever the raycast collides with into the array

        if (hits.Length >= 3)//when the array has collided with 3 or more yellow balls yellow wins 
        {
            yellowWin();
            Debug.Log("yellow up right win");
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(-1f, 1f, 0f), 4.24f, layerMask); //shoots a ray diagonally up left and puts whatever the raycast collides with into the array

        if (hits.Length >= 3)//when the array has collided with 3 or more yellow balls yellow wins 
        {
            yellowWin();
            Debug.Log("yellow up left win");
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(1f, -1f, 0f), 4.24f, layerMask); //shoots a ray diagonally down right and puts whatever the raycast collides with into the array

        if (hits.Length >= 3)//when the array has collided with 3 or more yellow balls yellow wins 
        {
            yellowWin();
            Debug.Log("yellow down right win");
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(-1f, -1f, 0f), 4.24f, layerMask); //shoots a ray diagonally down left and puts whatever the raycast collides with into the array

        if (hits.Length >= 3)//when the array has collided with 3 or more yellow balls yellow wins 
        {
            yellowWin();
            Debug.Log("yellow down left win");
        }
        hits = null;
    }

    //when yellow wins, change scenes and unlock the cursor
    void yellowWin()
    {
        
        winTimes = winTimes + 1;
        if (winTimes > 25)
        {
            Debug.Log("YELLOW WIN");
            Cursor.lockState = CursorLockMode.None;
            turn.turnChange();
            SceneManager.LoadScene("Yellowwinscene");
        }
    }


}

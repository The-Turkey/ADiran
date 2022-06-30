using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedWinCheck : MonoBehaviour
{
    public GameObject RedBall;

    public bool hasCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerEnter(Collider other)
    {

        float winCheckRange = 3f;//declares the range of the raycast

        int layerMask = 1 << 8;//means the raycast is only able to hit the red balls 

        

        

        if (!hasCollided)
        {
            Debug.Log("ball has collided with something");
            
            RaycastHit[] hits;//creates an array for whatever the raycast collides with

            hits = null;//empties the array 

            hits = Physics.RaycastAll(RedBall.transform.position, RedBall.transform.TransformDirection(Vector3.down), winCheckRange, layerMask); //shoots a ray downwards and puts whatever the raycast collides with into the array

            if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
            {
                redWin();
            }

            hits = null;//clear array

            hits = Physics.RaycastAll(RedBall.transform.position, RedBall.transform.TransformDirection(Vector3.left), winCheckRange, layerMask); //shoots a ray left and puts whatever the raycast collides with into the array

            if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
            {
                redWin();
            }

            hits = null;//clear array

            hits = Physics.RaycastAll(RedBall.transform.position, RedBall.transform.TransformDirection(Vector3.right), winCheckRange, layerMask); //shoots a ray right and puts whatever the raycast collides with into the array

            if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
            {
                redWin();
            }

            hits = null;//clear array

            hits = Physics.RaycastAll(RedBall.transform.position, RedBall.transform.TransformDirection(1f,1f,0f), 4.24f, layerMask); //shoots a ray diagonally up right and puts whatever the raycast collides with into the array

            if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
            {
                redWin();
            }

            hits = null;//clear array

            hits = Physics.RaycastAll(RedBall.transform.position, RedBall.transform.TransformDirection(-1f, 1f, 0f), 4.24f, layerMask); //shoots a ray diagonally up left and puts whatever the raycast collides with into the array

            if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
            {
                redWin();
            }

            hits = null;//clear array

            hits = Physics.RaycastAll(RedBall.transform.position, RedBall.transform.TransformDirection(1f, -1f, 0f), 4.24f, layerMask); //shoots a ray diagonally down right and puts whatever the raycast collides with into the array

            if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
            {
                redWin();
            }

            hits = null;//clear array

            hits = Physics.RaycastAll(RedBall.transform.position, RedBall.transform.TransformDirection(-1f, -1f, 0f), 4.24f, layerMask); //shoots a ray diagonally down left and puts whatever the raycast collides with into the array

            if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
            {
                redWin();
            }

            hasCollided = true;//means this script only runs once to reduce lag and to prevent bugs and errors

        }

       

    }

    void redWin()
    {
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("red win");//red has won
        SceneManager.LoadScene("redwinscene");
    }
}

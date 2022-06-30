using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YellowWinCheck : MonoBehaviour
{

    public GameObject YellowBall;
    public bool hasCollided = false;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        winConditions();
    }

    void OnTriggerEnter(Collider other)
    {


        if (!hasCollided)
        {
            Debug.Log("ball has collided with something");
            winConditions();
            hasCollided = true;//means this script only runs once to reduce lag and to prevent bugs and errors

        }



    }
    void yellowWin()
    {
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("yellow win");//yellow has won
        SceneManager.LoadScene("Yellowwinscene");
    }

    void winConditions()
    {
        float winCheckRange = 3f;//declares the range of the raycast

        int layerMask = 1 << 9;//means the raycast is only able to hit the yellow balls 

        RaycastHit[] hits;//creates an array for whatever the raycast collides with

        hits = null;//empties the array 

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(Vector3.down), winCheckRange, layerMask); //shoots a ray downwards and puts whatever the raycast collides with into the array

        if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
        {
            yellowWin();
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(Vector3.left), winCheckRange, layerMask); //shoots a ray left and puts whatever the raycast collides with into the array

        if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
        {
            yellowWin();
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(Vector3.right), winCheckRange, layerMask); //shoots a ray right and puts whatever the raycast collides with into the array

        if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
        {
            yellowWin();
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(1f, 1f, 0f), 4.24f, layerMask); //shoots a ray diagonally up right and puts whatever the raycast collides with into the array

        if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
        {
            yellowWin();
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(-1f, 1f, 0f), 4.24f, layerMask); //shoots a ray diagonally up left and puts whatever the raycast collides with into the array

        if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
        {
            yellowWin();
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(1f, -1f, 0f), 4.24f, layerMask); //shoots a ray diagonally down right and puts whatever the raycast collides with into the array

        if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
        {
            yellowWin();
        }

        hits = null;//clear array

        hits = Physics.RaycastAll(YellowBall.transform.position, YellowBall.transform.TransformDirection(-1f, -1f, 0f), 4.24f, layerMask); //shoots a ray diagonally down left and puts whatever the raycast collides with into the array

        if (hits.Length >= 5)//when the array has collided with 5 or more things (one ball counts as two collisions)
        {
            yellowWin();
        }
    }

    IEnumerator winCheck()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("second raycasts");
        winConditions();
    }
}

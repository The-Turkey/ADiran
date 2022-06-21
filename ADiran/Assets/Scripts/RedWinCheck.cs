using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                Debug.Log("red win");//red has won
            }

            hasCollided = true;//means this script only runs once to reduce lag and to prevent bugs and errors

        }

        /*if(Physics.Raycast(RedBall.transform.position, RedBall.transform.TransformDirection(Vector3.down), out hit, winCheckRange))
        {
            //Debug.Log(hit.transform.name);

            if (!hasRaycast)
            {
                if (hit.transform.gameObject.CompareTag("YellowBall"))
                {
                    Debug.Log("yellow ball hit");
                }
                else if (hit.transform.gameObject.CompareTag("RedBall"))
                {
                    Debug.Log("red ball hit");
                }

                hasRaycast = true;
            }

        }*/

    }

}

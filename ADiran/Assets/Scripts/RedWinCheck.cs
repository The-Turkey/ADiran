using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedWinCheck : MonoBehaviour
{
    public GameObject RedBall;

    public bool hasCollided = false;
    public bool hasRaycast = false;

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
        if (hasCollided == false) 
        {
            //Debug.Log("red ball goes boing");
            hasCollided = true;
        }


        RaycastHit hit;

        float winCheckRange = 10f;

        if(Physics.Raycast(RedBall.transform.position, RedBall.transform.TransformDirection(Vector3.down), out hit, winCheckRange))
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

        }


    }

}

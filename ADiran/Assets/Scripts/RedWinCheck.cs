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
        if (hasCollided == false) 
        {
            Debug.Log("red ball goes boing");
            hasCollided = true;
        }


        RaycastHit hit;

        float winCheckRange = 4f;

        /*if(Physics2D.RaycastAll(RedBall.transform.position, RedBall.transform.forward, winCheckRange))
        {
            Debug.Log(hit.transform.name);

            if (hit.transform.gameObject.CompareTag("RedBall"))
            {
                Debug.Log("ball hit");
            }


        }*/


    }

}

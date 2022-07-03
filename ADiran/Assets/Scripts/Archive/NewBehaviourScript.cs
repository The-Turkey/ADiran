using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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

/*if (hit.transform.gameObject.CompareTag("Button"))
{
    a.PressButton();
}*/

/*IEnumerator winCheck()
{
    yield return new WaitForSeconds(1f);
    Debug.Log("second raycasts");
    winConditions();
}*/

/*void OnTriggerEnter(Collider other)
{


    if (!hasCollided)
    {


        hasCollided = true;//means this script only runs once to reduce lag and to prevent bugs and errors

    }



}*/
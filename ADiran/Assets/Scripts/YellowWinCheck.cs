using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowWinCheck : MonoBehaviour
{
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
            //Debug.Log("yellow ball goes boing");
            hasCollided = true;
        }
    }
}

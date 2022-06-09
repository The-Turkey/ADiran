using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedWinCheck : MonoBehaviour
{
    public GameObject RedBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    RaycastHit2D[] goodHits(RaycastHit2D[] hits) { }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("red ball goes boing");
        RaycastHit2D[] Hits = goodHits(Physics2D.RaycastAll(RedBall.transform.position, RedBall.transform.up, 4f));
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick2 : MonoBehaviour
{
    //declares animation script
    public Animator PressAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PressButton()
    {
        StartCoroutine(PressingAnim());
    }

    //starts the animation
    IEnumerator PressingAnim()
    {
        PressAnim.SetBool("Pressing", true);
        yield return new WaitForSeconds(1f);
        PressAnim.SetBool("Pressing", false);

    }

}

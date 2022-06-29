using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick5 : MonoBehaviour
{
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

    IEnumerator PressingAnim()
    {
        PressAnim.SetBool("Pressing", true);
        yield return new WaitForSeconds(1f);
        PressAnim.SetBool("Pressing", false);

    }
}

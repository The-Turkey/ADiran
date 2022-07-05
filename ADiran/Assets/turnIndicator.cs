using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turnIndicator : MonoBehaviour
{
    public Image c;//declaring the image

    bool yellowOrRed = true;//true is yellow, false is red

    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Image>();//getting the image and assigning it to a variable

        c.material.color = new Color(1f,0f,0f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnChange()
    {
        if (yellowOrRed == true)
        {
            c.color = new Color(1f, 1f, 0f, 1f);//make panel yellow
            c.material.color = new Color(1f, 1f, 0f, 1f);//make panel yellow
            yellowOrRed = false;
        }
        else
        {
            c.color = new Color(1f, 0f, 0f, 1f);//otherwise make panel red
            c.material.color = new Color(1f, 0f, 0f, 1f);
            yellowOrRed = true;
        }
    }
}

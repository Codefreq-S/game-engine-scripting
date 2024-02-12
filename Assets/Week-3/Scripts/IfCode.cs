using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IfCode : MonoBehaviour
{
    public int apples;
    public int bananas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [ContextMenu("Execute If Test")] // This is a macro
    void ExecuteIfTest()
    {
        bool has4ApplesOr2Bananas = apples == 4 || bananas == 2;
        //bool has4ApplesAnd2Bananas = (apples == 4 && bananas == 2) ? true : false;
        int moneyOwed = (apples == 4 && bananas == 2) ? 200 : -200;

        //This if/else statement is exactly the same as the line above this comment
        int moneyOwed2 = 0;
        if (apples == 4 && bananas == 2)
        {
            moneyOwed2 = 200;
        }
        else
        {
            moneyOwed2 = -200;
        }
        //If either apples if 4 or bananas is 2
        //if (apples == 4 || apples == 3)
        if (has4ApplesOr2Bananas)
        {
            //Then print this message
            Debug.Log(string.Format("we have {0} apples and {1} bananas", apples, bananas));
        }
        //If both apples is 4 and bananas is 2
        if (apples == 4 && apples == 3)
        {
            //Then print the message
            Debug.Log(string.Format("we have {0} apples and {1} bananas", apples, bananas));
        }
        //If either apples or bananas is not 4/2 then if apples is 2 and bananas is less than
        //or equal to 10
        else if(apples == 2 && bananas <= 10)
        {
            Debug.Log(string.Format("we have {0} apples and {1} bananas", apples, bananas));
        }
        else if (apples == 2 || (apples == 4 && bananas > 0))
        {
            Debug.Log(string.Format("we have {0} apples and {1} bananas", apples, bananas));
        }
        else
        {
            Debug.Log("we do not have 4 apples");
        }
    }
}

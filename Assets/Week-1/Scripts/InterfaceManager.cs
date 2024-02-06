using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    public TextMeshProUGUI label;
    //private MathTypes mathtype = MathTypes.Multiply;
    public void InputValue(int n)
    {
        //Debug.Log(n);
        label.text += n.ToString();
    }
}

public enum MathTypes
{
    //Multiply
}
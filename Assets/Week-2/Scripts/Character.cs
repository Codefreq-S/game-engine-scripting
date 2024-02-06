using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    bool didUpdate = false;
    bool didLateUpdate = false;

    public static int health = 100;
    void Awake()
    {
        //instance = this;
        //Debug.Log(Character.health);
        Debug.Log("character is awake:");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I AM STARTING");
    }

    // Update is called once per frame
    void Update()
    {
        if(didUpdate)
        {
            Debug.Log("I AM UPDATED");
            Debug.LogWarning("STOP OR YOU WILL BE ARRESTED");
            Debug.LogError("TGIS ERROR SHOULD NOT HAPPEN EMAIL ccintron@colum.edu");
            didUpdate = true;
        }
    }
    void LateUpdate()
    {
        if(didLateUpdate)
        {
            Debug.Log("Late Update");
            didLateUpdate = true;
        }
    }
    void FixedUpdate()
    {
        
    }
    private void OnEnable()
    {
        Debug.Log("I am enabled");
    }

    private void OnDisable()
    {
        Debug.Log("I am disabled");
    }
}

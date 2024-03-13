using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpikeTrap : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerScore.Health -= 1;
        Debug.Log(PlayerScore.Health);
    }

    //pseudocode below:
    //void Animate() // Animation loop
    //{
    //    int YPositionMax
    //    int YPositionMin
    //    transform.Y += until YpositionMax
    //    //Hold for one second, then:
    //    transform.Y -= until YpositionMin
    //    //Hold for five seconds, then repeat animation
    //}
}

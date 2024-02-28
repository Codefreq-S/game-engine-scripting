using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class Flower : MonoBehaviour
{

    [SerializeField] float nectarProductionRate; // Make this reactive to game timer somehow
    [SerializeField] bool trackNectar; // true = track amount of nectar; false = do not track amount of nectar
    [SerializeField] private float nectarCount;
    [SerializeField] float gameTimer;
    [SerializeField] bool hasNectar; // May be useful for determining if a given "flower" object has nectar or not
    [SerializeField] float maxNectarCount = 5.0f; // To cap the amount of nectar a flower can have
    public bool availableNectarForBees; // broadcast to bees that this flower instance has nectar; true = yes, false = no


    //flowerColor; What type of variable should this be?

    public void SetSpriteColor()
    {
        if (nectarCount != 5) // If nectar count for flower is not full
        {
            GetComponent<SpriteRenderer>().color = Color.white; // no tint
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.red; // tinted red for "OUT OF NECTAR"
        }
    }

    public void GiveNectar() // Used as a placeholder so the Bee function referencing this won't generate errors
    {

    }

    //GetComponent: SpriteRenderer

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer = Time.deltaTime;
        if (nectarCount != null)
        {
            nectarCount += 1 * gameTimer; //Add to counter an extra 1 nectar count per unit of time determined by game timer
        }
        if (nectarCount >= maxNectarCount)
        {
            nectarCount = 5.0f;
        }
    }
}

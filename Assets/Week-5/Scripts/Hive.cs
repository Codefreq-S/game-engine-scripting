using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hive : MonoBehaviour
{
    [SerializeField] float honeyProductionRate;
    [SerializeField] int numberOfBeesAtStart = 4; // Not sure what to instantiate number of bees to be yet
    [SerializeField] int amountOfNectarInHive;
    [SerializeField] int amountOfHoneyInHive;
    [SerializeField] GameObject BeePrefab;

    //NOTE DeltaTime = amount of time passed between game frames

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++) // This instantiates 4 bees at start (zero-based)
        {
            Instantiate(BeePrefab, transform.position, BeePrefab.transform.rotation); // Creates a new bee at a given position (hive),
                                                                                      // at the rotational value specified by the Bee prefab
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //Come up with code to generate (increment) nectar value;
        //if nectar reachces a certain amount, generate bee(confirm this with direction)
    }
}

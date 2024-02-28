using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bee : MonoBehaviour
{
    [SerializeField] Hive beeHive;

    public void Init(Hive hive)
    {
        beeHive = hive; // The [SerializedField] is for accessing the Hive variable even though it's private (Prof. C told me it could)
    }
    Flower flower = new Flower(); // Is this syntax for instantiating a new flower object used in Unity scripting?
    void CheckAnyFlower()
    {
        flower.GiveNectar(); // NOTE: I think this is how I access a method from another C# class. Correct?
    }

    void Fly()
    {
        // COMMENTED CODE BELOW IS FOR DOTWEEN (SEE INSTRUCTIONS RELATED TO DOTWEEN)

        //Before the below code is implemented, use this:
        FindObjectsByType<Flower>(FindObjectsSortMode.None); // the ")" at the end may be a typo

        //transform.DOMove(flower.transform.position, 1f).OnComplete(() =>
        {
        //Take nectar from flower
        //If flower returned nectar then go back to the hive and give hive nectar
        //If flower did not return nectar then go check another flower

        }).SetEase(Ease.Linear);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

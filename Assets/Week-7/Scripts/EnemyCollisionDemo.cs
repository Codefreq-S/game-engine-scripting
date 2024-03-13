using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyCollisionDemo : MonoBehaviour
{
    public Material materialDamaged;
    public Material materialNormal;

    private MeshRenderer mr;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other) // This is for listening to triggers
    {
        if(other.gameObject.tag == "Enemy")
        {
            mr.material = materialDamaged;

            DOVirtual.DelayedCall(0.1f, () =>
            {
                mr.material = materialNormal;
            });
        }
    }

    private void OnTriggerStay(Collider other) // This is for listening to object as long as it is within the trigger
    {
        
    }

    private void OnTriggerExit(Collider other) // This is for listening to an object as soon as it leaves the trigger
    {
        
    }

    private void OnCollisionEnter(Collision collision) // This is for listening to physics, not triggers
    {
        
    }

    public void Damage()
    {
        Debug.Log("The bullet damaged me!");
    }
}

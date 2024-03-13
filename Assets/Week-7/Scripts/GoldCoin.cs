using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : MonoBehaviour
{
    Rigidbody rb;
    public GameObject Activated;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //pseudocode
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //SoundOnCollision.Play();
        Activated.SetActive(false);
        //counter++;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,5));
    }
}

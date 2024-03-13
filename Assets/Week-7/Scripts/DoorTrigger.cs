using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    [SerializeField] GameObject door;
    [SerializeField] float openSpeedModifier;
    //PlayerScore player;

    Vector3 origin;
    Vector3 target;

    bool isOpening;
    [SerializeField] bool needsCoins;
    float alpha;

    private void Awake()
    {
        origin = transform.position;
        target = origin + (Vector3.up * 5);
    }

    private void Update()
    {
        alpha += isOpening ? Time.deltaTime : -Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        door.transform.position = Vector3.Lerp(origin, target, alpha);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (needsCoins)
        {
            if (PlayerScore.GoldCoinCount == 4)
            {
                isOpening = true;
                door.transform.position = transform.position + (Vector3.up * 10);
            }
        }
        else
        {
            isOpening = true;
            //door.gameObject.SetActive(false);
            door.transform.position = transform.position + (Vector3.up * 10);
        }
        //isOpening = true;
        ////door.gameObject.SetActive(false);
        //door.transform.position = transform.position + (Vector3.up * 10);
    }

    private void OnTriggerExit(Collider other)
    {
        isOpening = false;
        //door.gameObject.SetActive(true);
        door.transform.position = origin;
    }
}

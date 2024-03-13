using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int GoldCoinCount = 0; // Use this as the counter for how many gold coins the player has; if the number reaches the level's Max, enable opening of exit door
    public static int Health = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            GoldCoinCount += 1;

            Destroy(other);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

    public GameObject coinPoof;
    public static int coinsAcquired = 0;

    public void OnCoinClicked() {
        Instantiate(coinPoof, transform.position, Quaternion.Euler(-90, 0, 0));
        Destroy(gameObject, 0.5f);
        coinsAcquired = coinsAcquired + 1;
        
    }

}

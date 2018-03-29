using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

    public GameObject coinPoof;
    public static int coinsCollected = 0;

    public void OnCoinClicked() {
        Instantiate(coinPoof, transform.position, Quaternion.Euler(-90, 0, 0));
        
        coinsCollected = coinsCollected + 1;

        Destroy(this.gameObject, 0.1f);

    }

}

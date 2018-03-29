using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public GameObject theDoor;
    public static bool keyCollected = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy

        Instantiate(keyPoof, transform.position, Quaternion.Euler(-90, 0, 0));
        theDoor.GetComponent<Door>().Unlock();
        keyCollected = true;
        Destroy(this.gameObject, 0.1f);
     
    }

}

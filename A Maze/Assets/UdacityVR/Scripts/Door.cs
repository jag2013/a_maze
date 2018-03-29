using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 

    public bool locked = true;

    // Create a boolean value called "opening" that can be checked in Update() 

    public bool isOpening = false;

    public AudioSource soundSource;

    public AudioClip doorLocked;

    public AudioClip doorOpening;

    public GameObject theBuilding;

    void Update() {
        // If the door is opening and it is not fully raised

        if (isOpening && transform.position.y < 7.5f)

        {

            // Animate the door raising up

            transform.Translate(0, 1.5f * Time.deltaTime, 0, Space.World);


        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked

        if (locked == false)
        {

            // Set the "opening" boolean to true

            isOpening = true;

            soundSource.clip = doorOpening;
            soundSource.Play();
            Destroy(theBuilding.GetComponent<BoxCollider>());






        } else
        {
            // (optionally) Else
            // Play a sound to indicate the door is locked

            soundSource.clip = doorLocked;
            soundSource.Play();

            
        }


    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}

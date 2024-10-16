using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlashLightDeath : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);

            //winTextObject.gameObject.SetActive(false);
            //winTextObject.text = "You lose!"; (Error here, check it out later)
        }
    }

}


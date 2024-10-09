using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlashLightDeath : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

            //winTextObject.gameObject.SetActive(false);
            //winTextObject.text = "You lose!"; (Error here, check it out later)
        }
    }

}


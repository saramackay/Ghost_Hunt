using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Toaster_Trigger : MonoBehaviour
{

    public GameObject Toasteron;
    public PlayableDirector Toastertimeline;

    void Start()
    {
        Toasteron.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!Toasteron.activeSelf)
        {
            Toasteron.SetActive(true);
            Toastertimeline.Play();
        }
    }
}
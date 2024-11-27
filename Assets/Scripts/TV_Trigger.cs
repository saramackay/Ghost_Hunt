using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TV_Trigger : MonoBehaviour
{

    public GameObject TVoff;
    public GameObject TVon;
    public PlayableDirector TVtimeline;

    void Start()
    {
        TVon.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!TVon.activeSelf)
        {
            TVoff.SetActive(false);
            TVon.SetActive(true);
            TVtimeline.Play();
        }
    }
}

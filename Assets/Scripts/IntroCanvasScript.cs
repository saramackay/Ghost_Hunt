using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCanvasScript : MonoBehaviour
{
    public GameObject IntroCanvas;

    void Start()
    {
        IntroCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Time.timeScale = 1;
            IntroCanvas.SetActive(false);
        }
    }
}

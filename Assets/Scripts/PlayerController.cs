using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject loseTextObject;
    public GameObject ButtonMenu;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
        ButtonMenu.SetActive(false);
    }



    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
           // winTextObject.gameObject.SetActive(true);//
           // ButtonMenu.SetActive(true);//
        }

        if (collision.gameObject.CompareTag("FlashLightObject"))
        {
            Destroy(gameObject);
            winTextObject.gameObject.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count == 4)
        {
            winTextObject.SetActive(true);
            rb.isKinematic = true;
        }
    }

    private void OnDestroy()
    {
        loseTextObject.SetActive(true);
    }

    //public void RestartButton()
  //  {
  //      SceneManager.LoadScene("Game");
   // }

 //   public void ExitButton()
 //   {
   //     SceneManager.LoadScene("MainMenu");
 //   }
}


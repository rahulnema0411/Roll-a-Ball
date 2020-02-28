using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_Movement : MonoBehaviour
{
    public Text Score;
    public Text Win;
    public Button button;
    public GameObject burst;
    public GameObject player;

    private int points;
    public float speed;
    private Rigidbody rb;
    public float friction = 2f;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        points = 0;
        Win.text = "";
        SetText();

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        float X_Input = Input.GetAxis("Horizontal");
        float Y_Input = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(X_Input, 0.0f, Y_Input);

        rb.AddForce(movement * speed * Time.deltaTime);


    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            points++;
            SetText();
        }

       
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {  
            if(Win.text == "")
            {
                Instantiate(burst, transform.position, transform.rotation);
                Win.text = "You Lost";
                Destroy(player.gameObject);
            }
            
        }
    }

    void SetText()
    {
        Score.text = "Score : " + points.ToString();
        if(points == 9)
        {
            Win.text = "You Win";
            
        }
    }

}

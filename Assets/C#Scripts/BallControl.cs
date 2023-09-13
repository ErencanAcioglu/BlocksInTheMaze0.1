using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BallControl : MonoBehaviour
{
    public Rigidbody move;
    public int velocity;
    public int count;
    public int objectCount;
    public TextMeshProUGUI score;
    public TextMeshProUGUI gameOver;

    private bool isGameOver = false;

    void Start()
    {
        move = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!isGameOver)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            move.AddForce(horizontal * velocity, 0, vertical * velocity);
        }

            
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isGameOver)
        {
            other.gameObject.SetActive(false);
            count++;
            score.text = "Score: " + count;

        }

        if (count == objectCount)
        {
            gameOver.gameObject.SetActive(true);
            isGameOver = true;
        }
        
    }

    
}

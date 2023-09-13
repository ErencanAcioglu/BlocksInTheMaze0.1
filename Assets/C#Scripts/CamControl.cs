using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamControl : MonoBehaviour
{
    public GameObject ball;
    public Vector3 difference;

    void Start()
    {
        difference = transform.position - ball.transform.position;
    }


    void LateUpdate()
    {
        transform.position = ball.transform.position + difference;
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

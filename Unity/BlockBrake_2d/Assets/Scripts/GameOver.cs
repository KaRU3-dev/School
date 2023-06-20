using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text gameOverMessage;

    [SerializeField] private bool isGameOver = false;

    private void Update()
    {
        if(isGameOver && Input.GetButtonDown("Submit"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameOverMessage.text = "Game Over";

        Destroy(collision.gameObject);

        isGameOver = true;
    }
}

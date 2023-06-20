using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
    Transform tr;
    AudioSource audioSource;

    public Text gameClearText;

    [SerializeField] private AudioClip sound;

    [SerializeField] private bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {
        tr = transform;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tr.childCount == 0)
        {
            gameClearText.text = "Game Clear";

            audioSource.PlayOneShot(sound);

            Time.timeScale = 0f;

            isGameClear = true;
        }

        if(isGameClear && Input.GetButtonDown("Submit"))
        {
            Time.timeScale = 1f;

            SceneManager.LoadScene("GameScene");
        }
    }
}

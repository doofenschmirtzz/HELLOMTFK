using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private Button pauseButton;

    [SerializeField]
    private GameObject loadingPanel, finishPanel, gameOverPanel, backgroundSfx;

    private AudioSource audioSource;
    public AudioClip alertSfx, finishSfx, getItemSfx;
    public bool alreadyPlayed = false;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            alreadyPlayed = false;
        }
    }

    //*********************************************************************
    // This function Manages all player collisions.
    //*********************************************************************

    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "trap" && alreadyPlayed == false)
        {
            //AudioSource.PlayClipAtPoint(runNowSfx, target.transform.position);
            Time.timeScale = 0;
            Destroy(backgroundSfx);
            gameOverPanel.SetActive(true);

            audioSource.PlayOneShot(alertSfx);
            alreadyPlayed = true;
        }

        //if (target.tag == "to1stFloor")
        //{
        //    //loadingPanel.SetActive(true);
        //    SceneManager.LoadScene("1st Floor");
        //}

        if (target.tag == "toGround")
        {
            loadingPanel.SetActive(true);
            SceneManager.LoadScene("Ground");
        }

        if (target.tag == "exit")
        {
            Time.timeScale = 0;
            audioSource.PlayOneShot(finishSfx);
            Destroy(backgroundSfx);

            finishPanel.SetActive(true);
            pauseButton.gameObject.SetActive(false);
        }

        if (target.tag == "_Item")
        {
            Destroy(target.gameObject);
            audioSource.PlayOneShot(getItemSfx);
        }
    }
}

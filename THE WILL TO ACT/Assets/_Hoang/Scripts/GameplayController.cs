using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour {

    [SerializeField]
    private Button pauseButton, backButton, toMainmenuButton, restartButton;

    [SerializeField]
    private GameObject pausePanel, loadingPanel, gameOverPanel, finishPanel;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void _PauseButton()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }

    public void _ResumeButton()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }

    public void _ToMainmenuButton()
    {
        pausePanel.SetActive(false);
        gameOverPanel.SetActive(false);
        finishPanel.SetActive(false);
        loadingPanel.SetActive(true);
        SceneManager.LoadScene("Main Menu");
    }

    public void _RestartButton()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("Map 2");
    }
}

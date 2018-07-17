using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    [SerializeField]
    private Button newGameButton, instructionButton, creditsButton, exitButton, yesButton, noButton;

    [SerializeField]
    private GameObject newGamePanel, instructionPanel, creditsPanel, loadingPanel, confirmExitPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //New Game Button
    public void _NewGameButton()
    {

        newGamePanel.SetActive(true);
    }

    //Back Button
    public void _BackButton()
    {
        if(newGamePanel == true)
        {
            newGamePanel.SetActive(false);
        }
        
        if(creditsPanel == true)
        {
            creditsPanel.SetActive(false);
        }

        if (instructionPanel == true)
        {
            instructionPanel.SetActive(false);
        }
    }

    //Instruction Button
    public void _InstructionButton()
    {
        instructionPanel.SetActive(true);
    }

    //Credits Button
    public void _CreditsButton()
    {
        creditsPanel.SetActive(true);
    }

    public void _ExitButton()
    {
        confirmExitPanel.SetActive(true);
    }

    ///Confirm Exit Panel
    public void _YesButton()
    {
        Application.Quit();
    }

    public void _NoButton()
    {
        confirmExitPanel.SetActive(false);
    }

    ///End Confirm Exit Panel

    // New Game Panel
    public void _Map1Button()
    {
        loadingPanel.SetActive(true);
        SceneManager.LoadScene("1st Floor");
    }

    public void _Map2Button()
    {
        loadingPanel.SetActive(true);
        SceneManager.LoadScene("Map 2");
    }
}

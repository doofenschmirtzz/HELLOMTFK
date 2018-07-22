using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    [SerializeField]
    private Button newGameButton, instructionButton, howToPlayButton, creditsButton, exitButton, yesButton, noButton;

    [SerializeField]
    private GameObject newGamePanel, howToPlayPanel, creditsPanel, loadingPanel, confirmExitPanel,
                        instructionPanel1, instructionPanel2, instructionPanel3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //New Game Button
    public void _NewGameButton()
    {
        exitButton.gameObject.SetActive(false);
        newGamePanel.SetActive(true);
    }

    //Back Button
    public void _BackButton()
    {
        if(newGamePanel == true)
        {
            newGamePanel.SetActive(false);
            exitButton.gameObject.SetActive(true);
        }
        
        if(creditsPanel == true)
        {
            creditsPanel.SetActive(false);
        }

        if (howToPlayPanel == true)
        {
            howToPlayPanel.SetActive(false);
        }
    }

    //Instruction Button
    public void _InstructionButton()
    {
        instructionPanel1.SetActive(true);
    }

    //How To Play Button
    public void _HowToPlayButton()
    {
        howToPlayPanel.SetActive(true);
    }

    //Credits Button
    public void _CreditsButton()
    {
        creditsPanel.SetActive(true);
    }

    public void _ExitButton()
    {
        confirmExitPanel.SetActive(true);

        //Disable Buttons
        newGameButton.interactable = false;
        instructionButton.interactable = false;
        howToPlayButton.interactable = false;
        creditsButton.interactable = false;
        exitButton.interactable = false;
    }

    ///Confirm Exit Panel
    public void _YesButton()
    {
        Application.Quit();
    }

    public void _NoButton()
    {
        confirmExitPanel.SetActive(false);

        //Enable Buttons
        newGameButton.interactable = true;
        instructionButton.interactable = true;
        howToPlayButton.interactable = true;
        creditsButton.interactable = true;
        exitButton.interactable = true;
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

    public void _Map3Button()
    {
        loadingPanel.SetActive(true);
        SceneManager.LoadScene("Demo");
    }

    //Instruction Panel
    public void _NextTo2Button()
    {
        instructionPanel1.SetActive(false);
        instructionPanel2.SetActive(true);
    }

    public void _NextTo3Button()
    {
        instructionPanel2.SetActive(false);
        instructionPanel3.SetActive(true);
    }

    public void _PrevTo1Button()
    {
        instructionPanel2.SetActive(false);
        instructionPanel1.SetActive(true);
    }

    public void _PrevTo2Button()
    {
        instructionPanel3.SetActive(false);
        instructionPanel2.SetActive(true);
    }

    public void _GotItButton()
    {
        instructionPanel3.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapController : MonoBehaviour {

    [SerializeField]
    public Button pauseButton;

    [SerializeField]
    public GameObject gameOverPanel;

    private AudioSource audioSource;
    public AudioClip alertSfx;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "_trap")
        {
            //AudioSource.PlayClipAtPoint(runNowSfx, target.transform.position);
            Time.timeScale = 0;

            pauseButton.gameObject.SetActive(false);
            audioSource.PlayOneShot(alertSfx);
            gameOverPanel.SetActive(true);
            
        }       

        //if (target.tag == "exit")
        //{
        //    Time.timeScale = 0;
        //    finishPanel.SetActive(true);
        //    pauseButton.gameObject.SetActive(false);
        //}
    }
}

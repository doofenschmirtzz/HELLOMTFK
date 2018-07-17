using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapController : MonoBehaviour {

    [SerializeField]
    private Button pauseButton;

    [SerializeField]
    private GameObject loadingPanel, finishPanel, gameOverPanel, backgroundSfx;

    private AudioSource audioSource;
    public AudioClip alertSfx, finishSfx, getItemSfx;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "trap")
        {
            //AudioSource.PlayClipAtPoint(runNowSfx, target.transform.position);
            Time.timeScale = 0;
            Destroy(backgroundSfx);
            gameOverPanel.SetActive(true);

            audioSource.PlayOneShot(alertSfx);
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

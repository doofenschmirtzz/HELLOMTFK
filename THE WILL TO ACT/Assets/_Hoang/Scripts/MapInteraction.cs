using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MapInteraction : MonoBehaviour {

    NavMeshAgent playerAgent;
    Animator anim;
    bool run;

    //Audio src
    //[SerializeField]
    //private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        playerAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) )
        {
            GetInteraction();
        }        
	}

    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interctionInfo;
        if (Physics.Raycast(interactionRay, out interctionInfo, Mathf.Infinity))
        {
            GameObject interactecdObject = interctionInfo.collider.gameObject;
            if (interactecdObject.tag == "Interactable Object")
            {
                Debug.Log("Interactable interacted.");
            }
            else
            {
                playerAgent.destination = interctionInfo.point;
                run = true;
            }
        }
        anim.SetBool("IsRunning", run);
    }
}

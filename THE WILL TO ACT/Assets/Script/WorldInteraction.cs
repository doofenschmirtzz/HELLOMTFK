using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour {

    NavMeshAgent playerAgent;
    private bool run=false;
    private Animator anim;
	// Use this for initialization
	void Start () {
        playerAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            GetInteraction();
        }
	}
    void GetInteraction()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        if(Physics.Raycast(ray,out interactionInfo,Mathf.Infinity))
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;
            if(interactedObject.tag=="Interactable Object")
            {
                Debug.Log("Interactable interacted.");
            }
            else
            {
                playerAgent.destination = interactionInfo.point;
                run = true;
            }
            
        }
        anim.SetBool("IsRunning", run);
        
    }
}

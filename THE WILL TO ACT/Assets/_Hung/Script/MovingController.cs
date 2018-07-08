using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovingController : MonoBehaviour {
    //   private Animator mAnimator;
    //   private NavMeshAgent mNavMeshAgent;
    //   private bool mRunning=false;
    //// Use this for initialization
    //void Start () {
    //       mAnimator = GetComponent<Animator>();
    //       mNavMeshAgent = GetComponent<NavMeshAgent>();
    //}

    //// Update is called once per frame
    //void Update () {
    //       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //       RaycastHit hit;
    //       if(Input.GetMouseButtonDown(1))
    //       {
    //           if(Physics.Raycast(ray,out hit,100))
    //           {
    //               mNavMeshAgent.destination = hit.point;
    //           }
    //       }
    //       if(mNavMeshAgent.remainingDistance<=mNavMeshAgent.stoppingDistance)
    //       {
    //           mRunning = false;
    //       }
    //       else
    //       {
    //           mRunning = true;
    //       }
    //       mAnimator.SetBool("IsRunning", mRunning);
    //}
    NavMeshAgent playerAgent;
    private bool run = false;
    private Animator animator;
    private bool crouch = false;
    // Use this for initialization
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            IGetInteraction();
        }
        if (Input.GetKey("c"))
        {
            Crouching();
        }
    }
    void Crouching()
    {
        crouch = true;
        run = false;
        animator.SetBool("IsCrouching", crouch);
        //if(Input.GetKeyDown("v"))
        //{
        //    crouch = false;
        //}
    }
    void IGetInteraction()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        if (Physics.Raycast(ray, out interactionInfo, Mathf.Infinity))
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;
            if (interactedObject.tag == "Interactable Object")
            {
                Debug.Log("Interactable interacted.");
            }
            else
            {
                playerAgent.destination = interactionInfo.point;
                run = true;
            }
        }
        animator.SetBool("IsRunning", run);
    }
} 

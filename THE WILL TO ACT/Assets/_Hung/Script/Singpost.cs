using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singpost : AcitonItem {
    public string[] dialogue;
    public override void Interact()
    {
        DialogueSystem.Instance.AddNewDialogue(dialogue, "sign");
        Debug.Log("Interacting with sing post.");

    }
}

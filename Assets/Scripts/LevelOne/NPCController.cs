using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    [SerializeField] Dialogue dialogue;

    public delegate void Interaction();
    public static Interaction OnInteraction;

    private void OnEnable()
    {
        OnInteraction += Interact;
    }

    private void OnDisable()
    {
        OnInteraction -= Interact;
    }
    public void Interact()
    {
        Debug.Log("interacting with bozo");
        StartCoroutine(DialogueController.Instance.ShowDialogue(dialogue));
    }
}
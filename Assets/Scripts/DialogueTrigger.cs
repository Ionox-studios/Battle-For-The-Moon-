using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private void Start()
    {
        TriggerDialogue();
        FindObjectOfType<DialogueManager>().DisplayNextSentence();
        StartCoroutine(ActivationRoutine());
    }
    private IEnumerator ActivationRoutine()
    {
        Debug.Log("SmoothSailing");
        //Wait for 14 secs.
        yield return new WaitForSeconds(2);

        //Turn My game object that is set to false(off) to True(on).
        Debug.Log("SmoothSailing");
        FindObjectOfType<DialogueManager>().DisplayNextSentence();

        yield return new WaitForSeconds(2);

        FindObjectOfType<DialogueManager>().DisplayNextSentence();
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}

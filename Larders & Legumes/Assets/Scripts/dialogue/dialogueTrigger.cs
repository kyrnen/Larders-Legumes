using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue Dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<dialogueManager>().startDialogue(Dialogue);
    }
        
    
}

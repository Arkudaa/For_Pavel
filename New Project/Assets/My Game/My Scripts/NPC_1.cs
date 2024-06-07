using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
        Speech.AddDialogue("0", "Welcome to our planet!", "1");
        Speech.AddDialogue("1", "Help us, please!", "2");
        Speech.AddDialogue("2", "We have been attacked by monsters!", "3");
        Speech.AddDialogue("3", "Go to the second island and defeat them all","4");
        Speech.AddDialogue("4", "On the third island is the final tower.");
    }

    // Triggered when the player comes in range of the NPC
    public override void OnTriggerNPC( Collider other ){
        Speech.SetDialogue("0");
	}
}
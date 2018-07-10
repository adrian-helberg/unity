using UnityEngine;

namespace NPCs
{
	public class Uschi : Npc
	{
		protected override void Interact()
		{
			DialogueSystem.Instance.AddNewDialogue(Dialogue, Name);
			
			Debug.Log("Interacted with " + Name);
		}
		
		private void Start()
		{
			Name = "Uschi";
			StoppingDistance = 2f;
			Dialogue = new string[3];
			Dialogue[0] = "Hi you fool!";
			Dialogue[1] = "You may bring me the sword ...";
			Dialogue[2] = "... for great advice!";
		}
	}
}
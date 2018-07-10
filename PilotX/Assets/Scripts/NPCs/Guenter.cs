using UnityEngine;

namespace NPCs
{
	public class Guenter : Npc 
	{
		protected override void Interact()
		{
			DialogueSystem.Instance.AddNewDialogue(Dialogue, Name);
			
			Debug.Log("Interacted with " + Name);
		}

		private void Start()
		{
			Name = "Guenter";
			StoppingDistance = 2f;
			Dialogue = new string[3];
			Dialogue[0] = "Hi I'm Guenter.";
			Dialogue[1] = "Traps are not gay.";
			Dialogue[2] = "Change my mind";
		}
	}
}


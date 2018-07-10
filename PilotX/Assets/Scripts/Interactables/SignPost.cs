using UnityEngine;

namespace Interactables
{
	public class SignPost : Interactable 
	{
		protected override void Interact()
		{
			DialogueSystem.Instance.AddNewDialogue(Dialogue, Name);
			
			Debug.Log("Interacted with " + Name);
		}
		
		private void Start()
		{
			Name = "Sign Post";
			StoppingDistance = 1f;
			Dialogue = new string[1];
			Dialogue[0] = "WARNING! Do not enter!";
		}
	}
}

using UnityEngine;

namespace Interactables
{
	public class SignPost : Interactable 
	{
		protected override void Interact()
		{
			Debug.Log("Interacted with " + Name);
		}
		
		private void Start()
		{
			Name = "Sign Post";
			StoppingDistance = 1f;
		}
	}
}

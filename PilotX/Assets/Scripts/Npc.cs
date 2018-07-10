using UnityEngine;

/**
 * Representation of non-player-characters
 */
public class Npc : Interactable
{
	protected override void Interact()
	{
		Debug.Log("Interacted with NPC");
	}

	private void Start()
	{
		Name = "Test Object";
		StoppingDistance = 0f;
		Dialogue = new string[1];
		Dialogue[0] = "I'm a test object";
	}
}

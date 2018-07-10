using UnityEngine;
using UnityEngine.AI;

/**
 * Objects the player can interact with
 */
public class Interactable : MonoBehaviour
{
	// Navigation
	[HideInInspector] public NavMeshAgent PlayerAgent;
	[HideInInspector] public float StoppingDistance;
	[HideInInspector] public string[] Dialogue;
	[HideInInspector] public string Name;
	
	private bool _hasInteracted;

	private void Update()
	{
		if (!_hasInteracted && PlayerAgent != null && !PlayerAgent.pathPending)
		{
			if (PlayerAgent.remainingDistance < PlayerAgent.stoppingDistance)
			{
				Interact();
				_hasInteracted = true;			
			}	
		}
	}
	
	public void MoveToInteraction(NavMeshAgent playerAgent)
	{
		_hasInteracted = false;
		PlayerAgent = playerAgent;
		playerAgent.stoppingDistance = StoppingDistance;
		playerAgent.destination = transform.position;
	}

	protected virtual void Interact()
	{
		Debug.Log("Interacted with Interactable");
	}

	private void Start()
	{
		// Set initial properties to detect errors in unity IDE
		PlayerAgent = null;
		_hasInteracted = false;
		Name = "";
		StoppingDistance = 0f;
		Dialogue = null;
	}
}

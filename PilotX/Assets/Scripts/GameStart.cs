using UnityEngine;

/**
 * Game start class attached to main camera is executed when scene is loaded and main camera is attached
 */
public class GameStart : MonoBehaviour {
	
	[Range(0.01f, 1.0f)] public float SmoothFactor;
	public Transform Target;
	
	private Vector3 _cameraOffset;
	
	private void Start()
	{
		Debug.Log("Game started");
		_cameraOffset = transform.position - Target.position;
		SmoothFactor = 0.2f;
	}

	private void LateUpdate()
	{
		var newPos = Target.position + _cameraOffset;
		transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
	}
}

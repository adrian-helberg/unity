using UnityEngine;
using UnityEngine.AI;

/**
 * Access to Raycasting objects from scene
 * due to object identifying on interaction
 */
public class WorldInteraction : MonoBehaviour
{
    [HideInInspector] public NavMeshAgent PlayerAgent;

    private void Start()
    {
        PlayerAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            GetInteraction();
        }
    }

    private void GetInteraction()
    {
        var interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;

        if (!Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity)) return;
        
        var interactedObject = interactionInfo.collider.gameObject;
        
        if (interactedObject.tag.Equals("Interactable Object"))
        {
            interactedObject.GetComponent<Interactable>().MoveToInteraction(PlayerAgent);
        }
        else
        {
            PlayerAgent.stoppingDistance = 0f;
            PlayerAgent.destination = interactionInfo.point;
        }
    }
}

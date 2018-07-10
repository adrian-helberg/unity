using UnityEngine;

/**
 * Objects that can be picked up
 */
public class Collectable : Interactable 
{
    protected override void Interact()
    {
        Debug.Log("Interacted with Collectable");
    }
}
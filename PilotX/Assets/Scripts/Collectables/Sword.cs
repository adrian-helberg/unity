using UnityEngine;

namespace Collectables
{
    public class Sword : Collectable
    {
        protected override void Interact()
        {
            Debug.Log("Interacted with " + Name);
        }

        private void Start()
        {
            Name = "Sword";
            StoppingDistance = 1;
        }
    }
}

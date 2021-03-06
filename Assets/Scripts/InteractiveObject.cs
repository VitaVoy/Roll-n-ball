using UnityEngine;

namespace Geekbrains
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        protected abstract void Interaction();

        public bool isInteractable { get; } = true;

        private string Player = nameof(Player);

        private void OnTriggerEnter(Collider other)
        {
            if (!isInteractable || !other.CompareTag(Player))
            {
                return;
            }

            Destroy(gameObject);
        }
    }
}

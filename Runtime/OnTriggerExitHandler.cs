using UnityEngine;

namespace Cochise.Collisions
{
    public class OnTriggerExitHandler : MonoBehaviour
    {
        [SerializeField]
        private ColliderEvent onTriggerExit;

        private void OnTriggerExit(Collider other)
        {
            onTriggerExit?.Invoke(other);
        }
    }
}

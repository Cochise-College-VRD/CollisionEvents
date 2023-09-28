using UnityEngine;

namespace Cochise.Collisions
{
    public class OnTriggerStayHandler : MonoBehaviour
    {
        [SerializeField]
        private ColliderEvent onTriggerStay;

        private void OnTriggerStay(Collider other)
        {
            onTriggerStay?.Invoke(other);
        }
    }
}

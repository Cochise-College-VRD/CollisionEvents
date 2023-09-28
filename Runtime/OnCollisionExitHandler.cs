using UnityEngine;

namespace Cochise.Collisions
{
    [RequireComponent(typeof(Collider))]
    public class OnCollisionExitHandler : MonoBehaviour
    {
        [SerializeField]
        private CollisionEvent onCollisionExit;
        private void OnCollisionExit(Collision collision)
        {
            onCollisionExit?.Invoke(collision);
        }
    }
}

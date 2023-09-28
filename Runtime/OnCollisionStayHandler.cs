using UnityEngine;

namespace Cochise.Collisions
{
    [RequireComponent(typeof(Collider))]
    public class OnCollisionStayHandler : MonoBehaviour
    {
        [SerializeField]
        private CollisionEvent onCollisionStay;

        private void OnCollisionStay(Collision collision)
        {
            onCollisionStay?.Invoke(collision);
        }
    }
}

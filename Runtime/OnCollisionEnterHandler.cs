using UnityEngine;

namespace Cochise.Collisions
{
    [RequireComponent(typeof(Collider))]
    public class OnCollisionEnterHandler : MonoBehaviour
    {
        [SerializeField]
        private CollisionEvent onCollisionEnter;

        private void OnCollisionEnter(Collision collision)
        {
            onCollisionEnter?.Invoke(collision);
        }
    }
}

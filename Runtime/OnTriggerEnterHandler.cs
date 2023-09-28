using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cochise.Collisions
{
    public class OnTriggerEnterHandler : MonoBehaviour
    {
        [SerializeField]
        private ColliderEvent onTriggerEnter;

        private void OnTriggerEnter(Collider other)
        {
            onTriggerEnter?.Invoke(other);
        }
    }
}

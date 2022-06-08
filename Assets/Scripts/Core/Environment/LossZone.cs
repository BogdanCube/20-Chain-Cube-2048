using System;
using UnityEngine;

namespace Core.Environment
{
    public class LossZone : MonoBehaviour
    {
        [SerializeField] private BoxCollider _collider;

        public void SetActiveZone(bool toggleState)
        {
            _collider.enabled = toggleState;
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.TryGetComponent(out Cube.Cube cube))
            {
                print("конец игры");
            }
        }
    }
}
using UnityEngine;

namespace Core.Cube
{
    public class Cube : MonoBehaviour
    {
        [SerializeField] private PhysicsCube _physicsCube;

        public PhysicsCube Physisc => _physicsCube;
    }
}
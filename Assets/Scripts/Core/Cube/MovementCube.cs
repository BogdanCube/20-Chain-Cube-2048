using UnityEngine;

namespace Core.Cube
{
    public class MovementCube : MonoBehaviour
    {
        [SerializeField] private float _powerLaunch;
        [SerializeField] private float _powerJump;
        [SerializeField] private Rigidbody _rigidbody;
        
        public void Move(Vector3 directionVector)
        {
            directionVector.y = transform.position.y;
            directionVector.z = transform.position.z;

            transform.position = Vector3.Lerp(transform.position, directionVector, 1f);
        }

        public void Launch()
        {
            _rigidbody.AddForce(transform.forward * _powerLaunch, ForceMode.Impulse);
        }
        public void Jump()
        {
            _rigidbody.AddForce(transform.up * _powerJump, ForceMode.Impulse);

        }
    }
}
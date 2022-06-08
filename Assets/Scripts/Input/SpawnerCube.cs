using Core.Cube;
using UnityEngine;

namespace InputCube
{
    public class SpawnerCube : MonoBehaviour
    {
        [SerializeField] private Cube _prefabCube;
        [SerializeField] private Vector3 _startPos;
        public void Spawn()
        {
            Instantiate(_prefabCube, _startPos, Quaternion.identity);
        }
    }
}
using Core.Cube.Level;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core.Cube
{
    public class Cube : MonoBehaviour
    {
        [SerializeField] private MovementCube _movement;
        [SerializeField] private LevelCube _level;
        public bool IsTapped = false;
        
        public MovementCube Movement => _movement;
        public LevelCube Level => _level;
    }
}
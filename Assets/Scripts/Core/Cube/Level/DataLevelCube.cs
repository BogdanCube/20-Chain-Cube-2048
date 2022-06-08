using UnityEngine;
using UnityEngine.Serialization;

namespace Core.Cube.Level
{
    [CreateAssetMenu(fileName = "DataLevelCube", menuName = "ScriptableObjects/DataLevelCube", order = 1)]
    public class DataLevelCube : ScriptableObject
    {
        [FormerlySerializedAs("Number")] public int Score;
        public Color Color;
    }
}
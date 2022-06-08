using UnityEngine;

namespace Core.Cube.Level
{
    [CreateAssetMenu(fileName = "DataLevelCube", menuName = "ScriptableObjects/DataLevelCube", order = 1)]
    public class DataLevelCube : ScriptableObject
    {
        public int Number;
        public Color Color;
    }
}
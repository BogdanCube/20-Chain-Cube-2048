using System;
using UnityEngine;

namespace Core.Cube.Level
{
    public class LevelCube : MonoBehaviour
    {
        [SerializeField] private int _currentLevel = -1;
        [SerializeField] private Cube _cube;
        [SerializeField] private LoaderLevel _loaderLevel;
        
        public int CurrentLevel => _currentLevel;
        public int CurrentScore => _loaderLevel.GetCurrentData(_currentLevel).Score;

        private void Start()
        {
            LevelUp();
        }

        [ContextMenu("LevelUp")]
        public void LevelUp()
        {
            _currentLevel++;
            _loaderLevel.LoadLevel(_currentLevel);
            _cube.Movement.Jump();
        }
    }
}
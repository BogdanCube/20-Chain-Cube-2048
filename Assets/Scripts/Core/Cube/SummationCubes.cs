using System;
using Core.Cube.Level;
using UI;
using UnityEngine;

namespace Core.Cube
{
    public class SummationCubes : MonoBehaviour
    {
        [SerializeField] private LevelCube _cube;
        private CounterScore _counterScore;

        private void Start()
        {
            _counterScore = FindObjectOfType<CounterScore>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out LevelCube secondCube))
            {
                if (_cube.CurrentLevel == secondCube.CurrentLevel)
                {
                    var score = _cube.CurrentScore;
                    _counterScore.AddScore(score);

                    _cube.LevelUp();
                    Destroy(secondCube.gameObject);
                }
            }        
        }
    }
}
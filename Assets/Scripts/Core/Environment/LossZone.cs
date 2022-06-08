using System;
using UI;
using UnityEngine;

namespace Core.Environment
{
    public class LossZone : MonoBehaviour
    {
        [SerializeField] private CounterScore _counterScore;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Cube.Cube cube))
            {
                if (cube.IsTapped == false)
                {
                    cube.IsTapped = true;
                }
                else
                {
                    _counterScore.SetText("Game Over");
                }
            }
        }
    }
}
using Ads;
using UnityEngine;
using Random = UnityEngine.Random;

namespace InputCube
{
    public class CounterLaunch : MonoBehaviour
    {
        [SerializeField] private DisplayedSimpleAds _displayedAds;
        [SerializeField] private int _currentCount;
        [SerializeField] private int _countToAds;

        private void Start()
        {
            _countToAds = Random.Range(10, 20);
        }

        public void AddCount()
        {
            _currentCount++;
            if (_currentCount >= _countToAds)
            {
                _displayedAds.Show();
                _currentCount = 0;
                _countToAds = Random.Range(10, 20);
            }
        }
    }
}
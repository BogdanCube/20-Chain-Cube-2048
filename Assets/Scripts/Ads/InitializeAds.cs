using GoogleMobileAds.Api;
using UnityEngine;

namespace Ads
{
    public class InitializeAds : MonoBehaviour
    {
        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            MobileAds.Initialize(status => {});
        }
    }
}
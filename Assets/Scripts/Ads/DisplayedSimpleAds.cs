using System;
using GoogleMobileAds.Api;
using UnityEngine;

namespace Ads
{
    public class DisplayedSimpleAds : MonoBehaviour
    {
        [SerializeField] private  string _id;
        private InterstitialAd _interstitialAd;
        private void Start()
        {
            Load();
        }

        private void Load()
        {
            _interstitialAd = new InterstitialAd(_id);
            AdRequest adRequest = new AdRequest.Builder().Build();
            _interstitialAd.LoadAd(adRequest);
        }

        [ContextMenu("Show")]
        public void Show()
        {
            if (_interstitialAd.IsLoaded())
            {
                _interstitialAd.Show();
            }
        }
    }
}
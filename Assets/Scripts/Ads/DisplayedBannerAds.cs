using GoogleMobileAds.Api;
using UnityEngine;

namespace Ads
{
    public class DisplayedBannerAds : MonoBehaviour
    {
        [SerializeField] private  string _id;
        private BannerView _banner;

        private void Start()
        {
            Show();
        }

        private void Show()
        {
            _banner = new BannerView(_id, AdSize.Banner, AdPosition.Bottom);
            AdRequest adRequest = new AdRequest.Builder().Build();
            
            _banner.LoadAd(adRequest);
            _banner.Show();
        }
    }
}
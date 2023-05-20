using System.Collections;
using Agava.YandexGames;
using UnityEngine;

namespace YandexSDK
{
    public class BannerAdd : MonoBehaviour
    {
        private bool _isReadyForBanner = true;
        private int _timeBetweenBanners = 35;
        private WaitForSeconds _waitNextBanner;
        
        private void OnEnable()
        {
            _waitNextBanner = new WaitForSeconds(_timeBetweenBanners);
            StartCoroutine(ShowStartBanner());
        }

        public void TryShowBanner()
        {
            if (_isReadyForBanner == false)
                return;
            
            InterstitialAd.Show();
            _isReadyForBanner = false;
            StartCoroutine(BannerRealod());
        }

        private IEnumerator ShowStartBanner()
        {
            yield return YandexGamesSdk.Initialize();
            TryShowBanner();
        }

        private IEnumerator BannerRealod()
        {
            yield return _waitNextBanner;
            _isReadyForBanner = true;
        }
    }
}
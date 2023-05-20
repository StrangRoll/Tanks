using Agava.YandexGames;
using UnityEngine;

namespace DefaultNamespace.YandexSDK
{
    public class YandexSDKInitializer : MonoBehaviour
    {
        private void Awake()
        {
            YandexGamesSdk.Initialize();
            DontDestroyOnLoad(this);
        }
    }
}
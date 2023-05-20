using Agava.YandexGames;
using UnityEngine;

namespace YandexSDK
{
    public class TryOpenLeaderboard : MonoBehaviour
    {
        [SerializeField] private Transform leaderboard;
        [SerializeField] private Transform back;

        public void TryOpen()
        {
            PlayerAccount.RequestPersonalProfileDataPermission();
            
            if (!PlayerAccount.IsAuthorized)
                PlayerAccount.Authorize();

            if (PlayerAccount.IsAuthorized)
            {
                back.gameObject.SetActive(true);
                leaderboard.gameObject.SetActive(true);
            }
        }
    }
}
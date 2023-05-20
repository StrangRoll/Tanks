using System;
using Agava.YandexGames;
using TMPro;
using UnityEngine;

namespace GameLogic
{
    public class ScoreCounter : MonoBehaviour
    {
        public static string Record = "Record"; 
            
        private static TMP_Text text;
        private static Canvas canvas;
        
        [SerializeField] private  TMP_Text text1;
        [SerializeField] private  Canvas canvas1;
        
        public static int Score { get; set; }

        private void Start()
        {
            text = text1;
            canvas = canvas1;   
        }

        public static void SetScore()
        {
            if (PlayerPrefs.HasKey(Record) == false)
                PlayerPrefs.SetInt(Record, 0);

            if (PlayerPrefs.GetInt(Record) < Score)
            {
                PlayerPrefs.SetInt(Record, Score);
            }

            SetLeaderboardScore();
            
            canvas.gameObject.SetActive(true);
            ;
            text.text = $"{Lean.Localization.LeanLocalization.GetTranslationText("Final score:")} {Score}";
        }
        
        private static void SetLeaderboardScore()
        {
            if (YandexGamesSdk.IsInitialized)
            {
                Leaderboard.GetPlayerEntry("LeaderBoard", OnSuccessCallback);
            }
        }

        private static void OnSuccessCallback(LeaderboardEntryResponse result)
        {
            if (result==null || PlayerPrefs.GetInt(Record) > result.score)
            {
                Leaderboard.SetScore("LeaderBoard", PlayerPrefs.GetInt(Record));
            }      
        }
    }
}
using System;
using TMPro;
using UnityEngine;

namespace GameLogic
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private static TMP_Text text;
        [SerializeField] private  TMP_Text text1;
        [SerializeField] private static Canvas canvas;
        [SerializeField] private  Canvas canvas1;
        
        public static int Score { get; set; }

        private void Start()
        {
            text = text1;
            canvas = canvas1;   
        }

        public static void SetScore()
        {
            canvas.gameObject.SetActive(true);
            text.text = $"Твой счёт: {Score}";
        }
    }
}
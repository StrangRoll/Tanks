using TMPro;
using UnityEngine;

namespace YandexSDK
{
    public class LeaderPosition : MonoBehaviour
    {
        [SerializeField] private TMP_Text nameField;
        [SerializeField] private TMP_Text scoreField;
        [SerializeField] private TMP_Text placeField;
        
        public void UpdateInfo(string place, string name, string score)
        {
            nameField.text = name;
            scoreField.text = score;
            placeField.text = place + ".";
        }
    }
}
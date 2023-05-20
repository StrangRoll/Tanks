using System.Collections.Generic;
using Agava.YandexGames;
using UnityEngine;

namespace YandexSDK
{
    public class LeaderBoard : MonoBehaviour
    {
        [SerializeField] private List<LeaderPosition> _positions;

        private int _topPlayerCount;    

        private void Awake()
        {
            _topPlayerCount = _positions.Count;
        }

        private void OnEnable()
        {
            Leaderboard.GetEntries("LeaderBoard", (result) => OnleaderboearInfoGot(result), (result) => OnError(result), _topPlayerCount, 1);
        }

        private void OnleaderboearInfoGot(LeaderboardGetEntriesResponse result)
        {
            var userRank = result.userRank;
            var isUserTop = (userRank <= _topPlayerCount);
            var scoreCount = _topPlayerCount > result.entries.Length ? result.entries.Length : _topPlayerCount;

            LeaderboardEntryResponse entry;
            string name;
            for (int i = 0; i < scoreCount; i++)
            {
                entry = result.entries[i];
                name = entry.player.publicName;

                if (string.IsNullOrEmpty(name))
                    name = Lean.Localization.LeanLocalization.GetTranslationText("Unknown player");

                _positions[i].UpdateInfo((i+1).ToString(), name, entry.score.ToString());
            }

            if (isUserTop) return;

            entry = result.entries[result.entries.Length - 3];
            name = entry.player.publicName;

            if (string.IsNullOrEmpty(name))
                name = Lean.Localization.LeanLocalization.GetTranslationText("Unknown player");

            _positions[_topPlayerCount - 2].UpdateInfo(entry.rank.ToString(), name, entry.score.ToString());

            entry = result.entries[result.entries.Length - 2];
            name = entry.player.publicName;

            if (string.IsNullOrEmpty(name))
                name = Lean.Localization.LeanLocalization.GetTranslationText("Unknown player");

            _positions[_topPlayerCount - 1].UpdateInfo(entry.rank.ToString(), name, entry.score.ToString());
        }

        private void OnError(string something)
        {
            Debug.Log(something);

            foreach (var position in _positions)
            {
                position.UpdateInfo("#","Error "," ");
            }
        }
    }
}
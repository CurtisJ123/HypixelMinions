using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class MurderMystery
    {
        #region general
        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("games")]
        public int Games { get; private set; }

        [JsonProperty("knife_kills")]
        public int KnifeKills { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("coins_pickedup")]
        public int CoinsPickedup { get; private set; }

        [JsonProperty("detective_chance")]
        public int DetectiveChance { get; private set; }

        [JsonProperty("murderer_chance")]
        public int MurdererChance { get; private set; }

        [JsonProperty("bow_kills")]
        public int BowKills { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("wasSpecialRoleLastGame")]
        public bool WasSpecialRoleLastGame { get; private set; }

        [JsonProperty("kills_as_murderer")]
        public int KillsAsMurderer { get; private set; }

        [JsonProperty("detective_wins")]
        public int DetectiveWins { get; private set; }

        [JsonProperty("murderer_wins")]
        public int MurdererWins { get; private set; }

        [JsonProperty("active_knife_skin")]
        public string ActiveKnifeSkin { get; private set; }

        [JsonProperty("suicides")]
        public int Suicides { get; private set; }
        #endregion

        #region chests
        [JsonProperty("granted_chests")]
        public int GrantedChests { get; private set; }

        [JsonProperty("mm_chests")]
        public int MmChests { get; private set; }

        [JsonProperty("mm_christmas_chests")]
        public int MmChristmasChests { get; private set; }

        [JsonProperty("MurderMystery_openedCommons")]
        public int MurderMysteryOpenedCommons { get; private set; }

        [JsonProperty("chest_history_new")]
        public List<string> ChestHistoryNew { get; private set; }

        [JsonProperty("MurderMystery_openedChests")]
        public int MurderMysteryOpenedChests { get; private set; }

        [JsonProperty("MurderMystery_openedRares")]
        public int MurderMysteryOpenedRares { get; private set; }

        [JsonProperty("MurderMystery_openedEpics")]
        public int MurderMysteryOpenedEpics { get; private set; }
        #endregion

        #region classic
        [JsonProperty("coins_pickedup_MURDER_CLASSIC")]
        public int CoinsPickedupMurderClassic { get; private set; }

        [JsonProperty("games_MURDER_CLASSIC")]
        public int GamesMurderClassic { get; private set; }

        [JsonProperty("wins_MURDER_CLASSIC")]
        public int WinsMurderClassic { get; private set; }

        [JsonProperty("deaths_MURDER_CLASSIC")]
        public int DeathsMurderClassic { get; private set; }

        [JsonProperty("detective_wins_MURDER_CLASSIC")]
        public int DetectiveWinsMurderClassic { get; private set; }

        [JsonProperty("murderer_wins_MURDER_CLASSIC")]
        public int MurdererWinsMurderClassic { get; private set; }

        [JsonProperty("knife_kills_MURDER_CLASSIC")]
        public int KnifeKillsMurderClassic { get; private set; }

        [JsonProperty("suicides_MURDER_CLASSIC")]
        public int SuicidesMurderClassic { get; private set; }
        #endregion

        #region assassins
        [JsonProperty("games_MURDER_ASSASSINS")]
        public int GamesMurderAssassins { get; private set; }

        [JsonProperty("deaths_MURDER_ASSASSINS")]
        public int DeathsMurderAssassins { get; private set; }

        [JsonProperty("coins_pickedup_MURDER_ASSASSINS")]
        public int CoinsPickedupMurderAssassins { get; private set; }

        [JsonProperty("knife_kills_MURDER_ASSASSINS")]
        public int KnifeKillsMurderAssassins { get; private set; }

        [JsonProperty("kills_MURDER_ASSASSINS")]
        public int KillsMurderAssassins { get; private set; }

        #endregion

        #region infection
        [JsonProperty("games_MURDER_INFECTION")]
        public int GamesMurderInfection { get; private set; }

        [JsonProperty("kills_as_survivor")]
        public int KillsAsSurvivor { get; private set; }

        [JsonProperty("kills_as_infected")]
        public int KillsAsInfected { get; private set; }

        [JsonProperty("survivor_wins")]
        public int SurvivorWins { get; private set; }
        #endregion
    }
}
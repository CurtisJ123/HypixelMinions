using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class HungerGames
    {
        [JsonProperty("arachnologist")]
        public int ArachnologistLevel { get; private set; }

        [JsonProperty("archer")]
        public int ArcherLevel { get; private set; }

        [JsonProperty("armorer")]
        public int ArmorerLevel { get; private set; }

        [JsonProperty("astronaut")]
        public int AstronautLevel { get; private set; }

        [JsonProperty("aura")]
        public string AuraLevel { get; private set; }

        [JsonProperty("baker")]
        public int BakerLevel { get; private set; }

        [JsonProperty("blaze")]
        public int BlazeLevel { get; private set; }

        [JsonProperty("blood")]
        public bool BloodLevel { get; private set; }

        [JsonProperty("chosen_taunt")]
        public string ChosenTaunt { get; private set; }

        [JsonProperty("coins")]
        public double Coins { get; private set; }

        [JsonProperty("creepertamer")]
        public int CreeperTamerLevel { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("fisherman")]
        public int FishermanLevel { get; private set; }

        [JsonProperty("horsetamer")]
        public int HorseTamerLevel { get; private set; }

        [JsonProperty("hunter")]
        public int HunterLevel { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("knight")]
        public int KnightLevel { get; private set; }

        [JsonProperty("meatmaster")]
        public int MeatmasterLevel { get; private set; }

        [JsonProperty("necromancer")]
        public int NecromancerLevel { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("pigman")]
        public int PigmanLevel { get; private set; }

        [JsonProperty("reddragon")]
        public int RedDragonLevel { get; private set; }

        [JsonProperty("rogue")]
        public int RogueLevel { get; private set; }

        [JsonProperty("scout")]
        public int ScoutLevel { get; private set; }

        [JsonProperty("slimeyslime")]
        public int SlimeySlimeLevel { get; private set; }

        [JsonProperty("snowman")]
        public int SnowmanLevel { get; private set; }

        [JsonProperty("speleologist")]
        public int SpeleologistLevel { get; private set; }

        [JsonProperty("tim")]
        public int TimLevel { get; private set; }

        [JsonProperty("toxicologist")]
        public int ToxicologistLevel { get; private set; }

        [JsonProperty("troll")]
        public int TrollLevel { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("wolftamer")]
        public int WolfTamerLevel { get; private set; }

        [JsonProperty("wins_teams")]
        public int WinsTeams { get; private set; }

        [JsonProperty("votes_Aelin's Tower")]
        public int VotesAelinSTower { get; private set; }

        [JsonProperty("votes_Egypt")]
        public int VotesEgypt { get; private set; }

        [JsonProperty("votes_Winter")]
        public int VotesWinter { get; private set; }

        [JsonProperty("votes_Caelum v2")]
        public int VotesCaelumV2 { get; private set; }

        [JsonProperty("votes_Valley")]
        public int VotesValley { get; private set; }

        [JsonProperty("paladin")]
        public int PaladinLevel { get; private set; }

        [JsonProperty("shadow knight")]
        public int ShadowKnightLevel { get; private set; }

        [JsonProperty("rambo_wins")]
        public int RamboWins { get; private set; }

        [JsonProperty("chosen_victorydance")]
        public string ChosenVictorydance { get; private set; }

        [JsonProperty("hype train")]
        public int HypeTrainLevel { get; private set; }

        [JsonProperty("jockey")]
        public int JockeyLevel { get; private set; }

        [JsonProperty("auratoggle")]
        public bool AuraToggle { get; private set; }

        [JsonProperty("chosen_finisher")]
        public string ChosenFinisher { get; private set; }

        [JsonProperty("votes_Mirador Basin")]
        public int VotesMiradorBasin { get; private set; }

        [JsonProperty("combatTracker")]
        public bool CombatTracker { get; private set; }

        [JsonProperty("reaper")]
        public int ReaperLevel { get; private set; }

        [JsonProperty("golem")]
        public int GolemLevel { get; private set; }

        [JsonProperty("florist")]
        public int FloristLevel { get; private set; }

        [JsonProperty("farmer")]
        public int FarmerLevel { get; private set; }

        [JsonProperty("autoarmor")]
        public bool AutoArmour { get; private set; }
    }
}

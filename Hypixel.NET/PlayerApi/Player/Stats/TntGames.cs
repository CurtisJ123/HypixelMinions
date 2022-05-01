using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class TntGames
    {
        [JsonProperty("coins")]
        public long Coins { get; private set; }

        [JsonProperty("deaths_bowspleef")]
        public long DeathsBowspleef { get; private set; }

        [JsonProperty("tags_bowspleef")]
        public long TagsBowspleef { get; private set; }

        [JsonProperty("spleef_doublejump")]
        public long SpleefDoublejump { get; private set; }

        [JsonProperty("spleef_triple")]
        public long SpleefTriple { get; private set; }

        [JsonProperty("record_pvprun")]
        public long RecordPvprun { get; private set; }

        [JsonProperty("record_tntrun")]
        public long RecordTntrun { get; private set; }

        [JsonProperty("capture_class")]
        public string CaptureClass { get; private set; }

        [JsonProperty("wins_tntrun")]
        public long WinsTntrun { get; private set; }

        [JsonProperty("kills_tntag")]
        public long KillsTntag { get; private set; }

        [JsonProperty("wins_tntag")]
        public long WinsTntag { get; private set; }

        [JsonProperty("winstreak")]
        public long Winstreak { get; private set; }

        [JsonProperty("new_kineticwizard_explode")]
        public long NewKineticwizardExplode { get; private set; }

        [JsonProperty("new_kineticwizard_regen")]
        public long NewKineticwizardRegen { get; private set; }

        [JsonProperty("new_pvprun_double_jumps")]
        public long NewPvprunDoubleJumps { get; private set; }

        [JsonProperty("new_witherwizard_regen")]
        public long NewWitherwizardRegen { get; private set; }

        [JsonProperty("new_spleef_tripleshot")]
        public long NewSpleefTripleshot { get; private set; }

        [JsonProperty("new_tntrun_double_jumps")]
        public long NewTntrunDoubleJumps { get; private set; }

        [JsonProperty("new_tntag_speedy")]
        public long NewTntagSpeedy { get; private set; }

        [JsonProperty("new_spleef_repulsor")]
        public long NewSpleefRepulsor { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("new_witherwizard_explode")]
        public long NewWitherwizardExplode { get; private set; }

        [JsonProperty("new_firewizard_regen")]
        public long NewFirewizardRegen { get; private set; }

        [JsonProperty("new_bloodwizard_explode")]
        public long NewBloodwizardExplode { get; private set; }

        [JsonProperty("new_icewizard_regen")]
        public long NewIcewizardRegen { get; private set; }

        [JsonProperty("new_spleef_double_jumps")]
        public long NewSpleefDoubleJumps { get; private set; }

        [JsonProperty("new_bloodwizard_regen")]
        public long NewBloodwizardRegen { get; private set; }

        [JsonProperty("new_firewizard_explode")]
        public long NewFirewizardExplode { get; private set; }

        [JsonProperty("new_icewizard_explode")]
        public long NewIcewizardExplode { get; private set; }

        [JsonProperty("run_potions_splashed_on_players")]
        public long RunPotionsSplashedOnPlayers { get; private set; }

        [JsonProperty("deaths_tntrun")]
        public long DeathsTntrun { get; private set; }

        [JsonProperty("tag_speeditup")]
        public long TagSpeeditup { get; private set; }

        [JsonProperty("tag_slowitdown")]
        public long TagSlowitdown { get; private set; }

        [JsonProperty("deaths_pvprun")]
        public long DeathsPvprun { get; private set; }

        [JsonProperty("kills_pvprun")]
        public long KillsPvprun { get; private set; }

        [JsonProperty("tag_blastprotection")]
        public long TagBlastprotection { get; private set; }

        [JsonProperty("wins_pvprun")]
        public long WinsPvprun { get; private set; }

        [JsonProperty("wins_bowspleef")]
        public long WinsBowspleef { get; private set; }

        [JsonProperty("votes_Forgotten Planet")]
        public long VotesForgottenPlanet { get; private set; }

        [JsonProperty("new_toxicwizard_explode")]
        public long NewToxicwizardExplode { get; private set; }

        [JsonProperty("new_firewizard_kills")]
        public long NewFirewizardKills { get; private set; }

        [JsonProperty("kills_capture")]
        public long KillsCapture { get; private set; }

        [JsonProperty("deaths_capture")]
        public long DeathsCapture { get; private set; }

        [JsonProperty("assists_capture")]
        public long AssistsCapture { get; private set; }

        [JsonProperty("wins")]
        public long Wins { get; private set; }

        [JsonProperty("new_tntrun_slowness_potions")]
        public long NewTntrunSlownessPotions { get; private set; }

        [JsonProperty("new_tntrun_speed_potions")]
        public long NewTntrunSpeedPotions { get; private set; }

        [JsonProperty("new_pvprun_fortitude")]
        public long NewPvprunFortitude { get; private set; }

        [JsonProperty("new_pvprun_notoriety")]
        public long NewPvprunNotoriety { get; private set; }

        [JsonProperty("new_active_death_effect")]
        public string NewActiveDeathEffect { get; private set; }

        [JsonProperty("new_selected_hat")]
        public string NewSelectedHat { get; private set; }

        [JsonProperty("new_tntrun_double_jumps_legacy")]
        public long NewTntrunDoubleJumpsLegacy { get; private set; }

        [JsonProperty("new_spleef_double_jumps_legacy")]
        public long NewSpleefDoubleJumpsLegacy { get; private set; }

        [JsonProperty("new_spleef_repulsor_legacy")]
        public long NewSpleefRepulsorLegacy { get; private set; }

        [JsonProperty("new_spleef_tripleshot_legacy")]
        public long NewSpleefTripleshotLegacy { get; private set; }

        [JsonProperty("new_pvprun_double_jumps_legacy")]
        public long NewPvprunDoubleJumpsLegacy { get; private set; }

        [JsonProperty("wizards_selected_class")]
        public string WizardsSelectedClass { get; private set; }

        [JsonProperty("new_firewizard_assists")]
        public long NewFirewizardAssists { get; private set; }

        [JsonProperty("points_capture")]
        public long PointsCapture { get; private set; }

        [JsonProperty("new_firewizard_deaths")]
        public long NewFirewizardDeaths { get; private set; }

        [JsonProperty("new_pvprun_regeneration")]
        public long NewPvprunRegeneration { get; private set; }

        [JsonProperty("wins_capture")]
        public long WinsCapture { get; private set; }

        [JsonProperty("new_toxicwizard_regen")]
        public long NewToxicwizardRegen { get; private set; }

        [JsonProperty("new_toxicwizard_deaths")]
        public long NewToxicwizardDeaths { get; private set; }

        [JsonProperty("new_toxicwizard_assists")]
        public long NewToxicwizardAssists { get; private set; }

        [JsonProperty("new_toxicwizard_kills")]
        public long NewToxicwizardKills { get; private set; }
    }
}
